using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ZooApp.data;
using ZooApp.Data;
using ZooApp.Models;

namespace ZooApp.Controllers
{
    public class EnclosuresController : Controller
    {
        private readonly ZooAppContext _context;
        private readonly IWebHostEnvironment _hostEnvironment;

        public EnclosuresController(ZooAppContext context, IWebHostEnvironment hostEnvironment)
        {
            _context = context;
            _hostEnvironment = hostEnvironment;
        }

        // GET: Enclosures/Index
        public async Task<IActionResult> Index(string searchString)
        {
            ViewData["EnclosureNameFilter"] = searchString;
            var enclosures = from e in _context.Enclosure.Include(e => e.Employees)
                             select e;

            if (!String.IsNullOrEmpty(searchString))
            {
                enclosures = enclosures.Where(e => e.Name.Contains(searchString));
            }

            var enclosureList = await enclosures.ToListAsync(); // Creates a list of all the enclosure assigned to a variable called enclosureList which is initialized to ne equalled to the list of enclosure.

            if (enclosureList.Count == 0) // If the list of enclosure is 0, the programme will return the NoEnclosures view to the user promptin them to go back to the index view.
            {
                return View("NoEnclosures");
            }

            return View(enclosureList);
        }

        // GET: Enclosures/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var enclosure = await _context.Enclosure
                .Include(e => e.Animals)
                .FirstOrDefaultAsync(m => m.EnclosureId == id);

            if (enclosure == null)
            {
                return NotFound();
            }

            return View(enclosure);
        }


        // GET: Enclosures/Create
        [Authorize(Roles = "Admin")]
        public IActionResult Create()
        {
            return View();
        }

        // POST: Enclosures/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Create([Bind("EnclosureId,Name,Habitat,Capacity,ImageFile")] Enclosure enclosure)
        {
            if (ModelState.IsValid)
            {
                return View(enclosure);
            }

            if (enclosure.ImageFile != null && enclosure.ImageFile.Length > 0)
            {
                // Handle file upload
                string uniqueFileName = UploadImage(enclosure.ImageFile);
                enclosure.ImageFileName = uniqueFileName;
            }

            _context.Add(enclosure);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        // GET: Enclosures/Edit/5
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var enclosure = await _context.Enclosure.FindAsync(id);
            if (enclosure == null)
            {
                return NotFound();
            }

            return View(enclosure);
        }

        // POST: Enclosures/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Edit(int id, [Bind("EnclosureId,Name,Habitat,Capacity,ImageFileName,ImageFile")] Enclosure enclosure)
        {
            if (id != enclosure.EnclosureId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                return View(enclosure);
            }

            try
            {
                // Retrieve the existing enclosure entity without tracking
                var existingEnclosure = await _context.Enclosure
                    .AsNoTracking()
                    .FirstOrDefaultAsync(e => e.EnclosureId == id);

                if (existingEnclosure == null)
                {
                    return NotFound();
                }

                if (enclosure.ImageFile != null && enclosure.ImageFile.Length > 0)
                {
                    // Handle file upload and update ImageFileName
                    enclosure.ImageFileName = UploadImage(enclosure.ImageFile);
                }
                else if (string.IsNullOrEmpty(enclosure.ImageFileName))
                {
                    // If no new ImageFile is provided and ImageFileName is null or empty,
                    // set it to the existing ImageFileName to maintain the current image
                    enclosure.ImageFileName = existingEnclosure.ImageFileName;
                }

                _context.Update(enclosure);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EnclosureExists(enclosure.EnclosureId))
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

        // Helper method to handle file upload and return unique file name
        private string UploadImage(IFormFile imageFile)
        {
            string uniqueFileName = null;
            if (imageFile != null && imageFile.Length > 0)
            {
                // Get the uploads folder path
                string uploadsFolder = Path.Combine(_hostEnvironment.WebRootPath, "images");

                // Generate a unique file name using timestamp
                string fileName = Path.GetFileNameWithoutExtension(imageFile.FileName);
                string extension = Path.GetExtension(imageFile.FileName);
                string timestamp = DateTime.Now.ToString("yyyyMMddHHmmssfff");
                uniqueFileName = fileName + "_" + timestamp + extension;

                // Combine the path with the unique file name
                string filePath = Path.Combine(uploadsFolder, uniqueFileName);

                // Save the file to the specified path
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    imageFile.CopyTo(fileStream);
                }
            }
            return uniqueFileName;
        }

    // GET: Enclosures/Delete/5
    [Authorize(Roles = "Admin, Employee")]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var enclosure = await _context.Enclosure
                .FirstOrDefaultAsync(m => m.EnclosureId == id);
            if (enclosure == null)
            {
                return NotFound();
            }

            return View(enclosure);
        }

        // POST: Enclosures/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin, Employee")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var enclosure = await _context.Enclosure.FindAsync(id);

            if (enclosure == null)
            {
                return NotFound();
            }

            // Remove related animals
            var relatedAnimals = _context.Animal.Where(a => a.EnclosureId == id);
            _context.Animal.RemoveRange(relatedAnimals);

            // Remove the enclosure
            _context.Enclosure.Remove(enclosure);

            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        // Helper method to check if an enclosure exists by its ID
        private bool EnclosureExists(int id)
        {
            return _context.Enclosure.Any(e => e.EnclosureId == id);
        }

    }




}
