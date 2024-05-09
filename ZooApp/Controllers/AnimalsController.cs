using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ZooApp.Models;
using ZooApp.data;
using Microsoft.Data.SqlClient;
using Microsoft.AspNetCore.Authorization;

namespace ZooApp.Controllers
{
    public class AnimalsController : Controller
    {
        private readonly ZooAppContext _context;

        public AnimalsController(ZooAppContext context)
        {
            _context = context;
        }

        // GET: Animals

        public async Task<IActionResult> Index(string searchString, int? searchId , String SortOrder)
        {
            ViewData["AnimalNameFilter"] = searchString;
            ViewData["AnimalIdFilter"] = searchId;

            var animals = from a in _context.Animal select a;

            if (!String.IsNullOrEmpty(searchString))
            {
                animals = animals.Where(a => a.Name.Contains(searchString));
            }

            if (searchId.HasValue)
            {
                animals = animals.Where(a => a.AnimalId == searchId.Value);
            }

         
            var zooAppContext = _context.Animal.Include(a => a.Employee).Include(a => a.Enclosure);
            return View(await animals.ToListAsync());
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
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin,Employee")]
        public async Task<IActionResult> Create([Bind("AnimalId,Name,Species,Age,Sex,Diet,EmployeeId,EnclosureId")] Animal animal)
        {
            if (ModelState.IsValid)
            {
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
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin,Employee")]
        public async Task<IActionResult> Edit(int id, [Bind("AnimalId,Name,Species,Age,Sex,Diet,EmployeeId,EnclosureId")] Animal animal)
        {
            if (id != animal.AnimalId)
            {
                return NotFound();
            }

            if (!ModelState.IsValid)
            {
                try
                {
                    _context.Update(animal);
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
            ViewData["EmployeeId"] = new SelectList(_context.Employee, "EmployeeId", "Name", animal.EmployeeId);
            ViewData["EnclosureId"] = new SelectList(_context.Enclosure, "EnclosureId", "Name", animal.EnclosureId);
            return View(animal);
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
        [Authorize(Roles = "Admin,Employee")]
         [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
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
