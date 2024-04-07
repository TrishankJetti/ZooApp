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
        private readonly ZooAppContext _context;

        public EnclosuresController(ZooAppContext context)
        {
            _context = context;
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
        [Authorize(Roles = "Admin , Employee")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var enclosure = await _context.Enclosure.FindAsync(id);
            if (enclosure != null)
            {
                _context.Enclosure.Remove(enclosure);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EnclosureExists(int id)
        {
            return _context.Enclosure.Any(e => e.EnclosureId == id);
        }
    }
}
