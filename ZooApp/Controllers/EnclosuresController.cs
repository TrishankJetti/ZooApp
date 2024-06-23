using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ZooApp.data;
using ZooApp.Models;

namespace ZooApp.Controllers
{
    public class EnclosuresController : Controller
    {
        public async Task<IActionResult> Quiz()
        {


            return View();
        }
        private readonly ZooAppContext _context;

        public EnclosuresController(ZooAppContext context)
        {
            _context = context;
        }
        private bool EnclosureExists(int id)
        {
            return _context.Enclosure.Any(e => e.EnclosureId == id);
        }

        // GET: Enclosures
        public async Task<IActionResult> Index(string searchString)
        {
            ViewData["EnclosureNameFilter"] = searchString;
            var enclosures = from e in _context.Enclosure.Include(e => e.Employees)
                            select e;

            if (!String.IsNullOrEmpty(searchString))
            {
                enclosures = enclosures.Where(e => e.Name.Contains(searchString));
            }

            return View(await enclosures.ToListAsync());
        }


        // GET: Enclosures/Details/5
        public async Task<IActionResult> Details(int? id)
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

        // GET: Enclosures/Create
        [Authorize(Roles = "Admin , Employee")]
        public IActionResult Create()
        {
            return View();
        }

        // POST: Enclosures/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin , Employee")]
        public async Task<IActionResult> Create([Bind("EnclosureId,Name,Habitat,Capacity")] Enclosure enclosure)
        {
            if (!ModelState.IsValid)
            {
                _context.Add(enclosure);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(enclosure);
        }

        // GET: Enclosures/Edit/5
        [Authorize(Roles = "Admin , Employee")]
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
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin , Employee")]
        public async Task<IActionResult> Edit(int id, [Bind("EnclosureId,Name,Habitat,Capacity")] Enclosure enclosure)
        {
            if (id != enclosure.EnclosureId)
            {
                return NotFound();
            }

            if (!ModelState.IsValid)
            {
                try
                {
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
            return View(enclosure);
        }

        // GET: Enclosures/Delete/5
        [Authorize(Roles = "Admin , Employee")]
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

            //This new variable relatedAnimals, is intialized to be equaled to the Animals in the particular enclosure, via the use of the enclosureid 
            //as a unique identifier.
            var relatedAnimals = _context.Animal.Where(a => a.EnclosureId == id);

            // Removes the relaredAnimals , which are animals related to that enclosure.
            _context.Animal.RemoveRange(relatedAnimals);

            // THis code removes the enclosure from the database.
            _context.Enclosure.Remove(enclosure);

            //saves changes after removal
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }


    }
}
