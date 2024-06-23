using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using ZooApp.data;
using ZooApp.Data;
using ZooApp.Models;

namespace ZooApp.Controllers
{
    public class AnimalsController : Controller
    {
        private readonly ZooAppContext _context;
        private readonly IWebHostEnvironment _hostEnvironment;

        public AnimalsController(ZooAppContext context, IWebHostEnvironment hostEnvironment)
        {
            _context = context;
            _hostEnvironment = hostEnvironment;
        }

        // GET: Animals
        public async Task<IActionResult> Index(string searchString, int? searchId, string sortOrder, string dietType, int? age, int? pageNumber, string currentFilter, string currentDietType)
        {
            // Initialize ViewData for filters and sorting
            ViewData["CurrentSort"] = sortOrder;
            ViewData["AnimalNameFilter"] = searchString;
            ViewData["AnimalIdFilter"] = searchId;
            ViewData["DietTypeFilter"] = string.IsNullOrEmpty(dietType) ? currentDietType : dietType;

            // Sorting parameters
            ViewData["AnimalAgeSorter"] = sortOrder == "Age" ? "age_desc" : "Age";
            ViewData["AnimalNameSort"] = string.IsNullOrEmpty(sortOrder) ? "name_desc" : "";

            // Pagination 
            if (searchString != null || dietType != currentDietType || searchId.HasValue)
            {
                pageNumber = 1; // Reset to first page if filters change
            }
            else
            {
                searchString = currentFilter; // Use previous filter
            }

            // Query the animals with initial filtering
            var animals = from a in _context.Animal.Include(a => a.Employee).Include(a => a.Enclosure)
                          select a;

            // Apply filtering
            if (!string.IsNullOrEmpty(searchString))
            {
                animals = animals.Where(a => a.Name.Contains(searchString));
            }

            if (searchId.HasValue)
            {
                animals = animals.Where(a => a.AnimalId == searchId.Value);
            }

            if (!string.IsNullOrEmpty(dietType))
            {
                animals = animals.Where(a => a.Diet == Enum.Parse<DietType>(dietType));
            }


           
            // Apply sorting
            switch (sortOrder)
            {
                case "name_desc":
                    animals = animals.OrderByDescending(a => a.Name);
                    break;
                case "age_desc":
                    animals = animals.OrderByDescending(a => a.Age);
                    break;
                case "Age":
                    animals = animals.OrderBy(a => a.Age);
                    break;
                default:
                    animals = animals.OrderBy(a => a.Name);
                    break;
            }




            // Page size and pagination
            int pageSize = 3;
            var paginatedAnimals = await PaginatedList<Animal>.CreateAsync(animals.AsNoTracking(), pageNumber ?? 1, pageSize);

            if (paginatedAnimals.Any())
            {
                return View(paginatedAnimals);
            }
            else
            {
                return View("NoAnimals");
            }
        }

        // GET: Animals/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var animal = await _context.Animal
                .Include(a => a.Employee)
                .Include(a => a.Enclosure)
                .FirstOrDefaultAsync(m => m.AnimalId == id);
            if (animal == null)
            {
                return NotFound();
            }

            return View(animal);
        }

        // GET: Animals/Create
        [Authorize(Roles = "Admin,Employee")]
        public IActionResult Create()
        {
            ViewData["EmployeeId"] = new SelectList(_context.Employee, "EmployeeId", "Name");
            ViewData["EnclosureId"] = new SelectList(_context.Enclosure, "EnclosureId", "Name");
            return View();
        }

        // POST: Animals/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin,Employee")]
        public async Task<IActionResult> Create([Bind("AnimalId,Name,Species,Age,Sex,Diet,EmployeeId,EnclosureId,ImageFile")] Animal animal)
        {
            if (!ModelState.IsValid)
            {
                var enclosure = await _context.Enclosure
                    .Include(e => e.Animals)
                    .FirstOrDefaultAsync(e => e.EnclosureId == animal.EnclosureId);

                if (enclosure == null)
                {
                    return NotFound();
                }

                if (enclosure.Animals.Count >= enclosure.Capacity)
                {
                    ModelState.AddModelError(string.Empty, "This enclosure is at full capacity. Please choose another enclosure or create a new one.");
                    ViewData["EmployeeId"] = new SelectList(_context.Employee, "EmployeeId", "Name", animal.EmployeeId);
                    ViewData["EnclosureId"] = new SelectList(_context.Enclosure, "EnclosureId", "Name", animal.EnclosureId);
                    return View(animal);
                }

                if (animal.ImageFile != null)
                {
                    string uploadsFolder = Path.Combine(_hostEnvironment.WebRootPath, "images");
                    string uniqueFileName = Guid.NewGuid().ToString() + "_" + animal.ImageFile.FileName;
                    string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                    using (var fileStream = new FileStream(filePath, FileMode.Create))
                    {
                        await animal.ImageFile.CopyToAsync(fileStream);
                    }
                    animal.ImageFileName = uniqueFileName;
                }

                _context.Add(animal);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            ViewData["EmployeeId"] = new SelectList(_context.Employee, "EmployeeId", "Name", animal.EmployeeId);
            ViewData["EnclosureId"] = new SelectList(_context.Enclosure, "EnclosureId", "Name", animal.EnclosureId);
            return View(animal);
        }


        // GET: Animals/Edit/5
        [Authorize(Roles = "Admin,Employee")]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var animal = await _context.Animal.FindAsync(id);
            if (animal == null)
            {
                return NotFound();
            }
            ViewData["EmployeeId"] = new SelectList(_context.Employee, "EmployeeId", "Name", animal.EmployeeId);
            ViewData["EnclosureId"] = new SelectList(_context.Enclosure, "EnclosureId", "Name", animal.EnclosureId);
            return View(animal);
        }


        // POST: Animals/Edit/5
        // POST: Animals/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin,Employee")]
        public async Task<IActionResult> Edit(int id, [Bind("AnimalId,Name,Species,Age,Sex,Diet,EmployeeId,EnclosureId,ImageFileName,ImageFile")] Animal animal)
        {
            if (id != animal.AnimalId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                ViewData["EmployeeId"] = new SelectList(_context.Employee, "EmployeeId", "Name", animal.EmployeeId);
                ViewData["EnclosureId"] = new SelectList(_context.Enclosure, "EnclosureId", "Name", animal.EnclosureId);
                return View(animal);
            }

            try
            {
                // Retrieve the existing entity without tracking
                var existingAnimal = await _context.Animal.AsNoTracking().FirstOrDefaultAsync(a => a.AnimalId == id);
                if (existingAnimal == null)
                {
                    return NotFound();
                }

                // Update specific properties only
                existingAnimal.Name = animal.Name;
                existingAnimal.Species = animal.Species;
                existingAnimal.Age = animal.Age;
                existingAnimal.Sex = animal.Sex;
                existingAnimal.Diet = animal.Diet;
                existingAnimal.EmployeeId = animal.EmployeeId;
                existingAnimal.EnclosureId = animal.EnclosureId;

                // Handle image file update if a new file is uploaded
                if (animal.ImageFile != null)
                {
                    string uploadsFolder = Path.Combine(_hostEnvironment.WebRootPath, "images");
                    string uniqueFileName = Guid.NewGuid().ToString() + "_" + animal.ImageFile.FileName;
                    string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                    using (var fileStream = new FileStream(filePath, FileMode.Create))
                    {
                        await animal.ImageFile.CopyToAsync(fileStream);
                    }
                    existingAnimal.ImageFileName = uniqueFileName;
                }

                // Update the entity in the database
                _context.Update(existingAnimal);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AnimalExists(animal.AnimalId))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToAction(nameof(Index));
        }




        // GET: Animals/Delete/5
        [Authorize(Roles = "Admin,Employee")]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var animal = await _context.Animal
                .Include(a => a.Employee)
                .Include(a => a.Enclosure)
                .FirstOrDefaultAsync(m => m.AnimalId == id);
            if (animal == null)
            {
                return NotFound();
            }

            return View(animal);
        }

        // POST: Animals/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin,Employee")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var animal = await _context.Animal.FindAsync(id);
            if (animal != null)
            {
                _context.Animal.Remove(animal);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AnimalExists(int id)
        {
            return _context.Animal.Any(e => e.AnimalId == id);
        }
    }
}
