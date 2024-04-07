using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ZooApp.Models;
using ZooApp.data;
using Microsoft.AspNetCore.Authorization;

namespace ZooApp.Controllers
{
    public class AnimalEmployeesController : Controller
    {
        private readonly ZooAppContext _context;

        public AnimalEmployeesController(ZooAppContext context)
        {
            _context = context;
        }

        // GET: AnimalEmployees
        public async Task<IActionResult> Index()
        {
            var zooAppContext = _context.AnimalEmployee.Include(a => a.Animal).Include(a => a.Employee);
            return View(await zooAppContext.ToListAsync());
        }

        // GET: AnimalEmployees/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var animalEmployee = await _context.AnimalEmployee
                .Include(a => a.Animal)
                .Include(a => a.Employee)
                .FirstOrDefaultAsync(m => m.AnimalEmployeeId == id);
            if (animalEmployee == null)
            {
                return NotFound();
            }

            return View(animalEmployee);
        }

        // GET: AnimalEmployees/Create
        [Authorize(Roles = "Admin,Employee")]
        public IActionResult Create()
        {
            ViewData["AnimalId"] = new SelectList(_context.Animal, "AnimalId", "Name");
            ViewData["EmployeeId"] = new SelectList(_context.Employee, "EmployeeId", "Name");
            return View();
        }

        // POST: AnimalEmployees/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin,Employee")]
        public async Task<IActionResult> Create([Bind("AnimalEmployeeId,EmployeeId,AnimalId")] AnimalEmployee animalEmployee)
        {
            if (!ModelState.IsValid)
            {
                _context.Add(animalEmployee);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["AnimalId"] = new SelectList(_context.Animal, "AnimalId", "Name", animalEmployee.AnimalId);
            ViewData["EmployeeId"] = new SelectList(_context.Employee, "EmployeeId", "Name", animalEmployee.EmployeeId);
            return View(animalEmployee);
        }

        // GET: AnimalEmployees/Edit/5
        [Authorize(Roles = "Admin,Employee")]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var animalEmployee = await _context.AnimalEmployee.FindAsync(id);
            if (animalEmployee == null)
            {
                return NotFound();
            }
            ViewData["AnimalId"] = new SelectList(_context.Animal, "AnimalId", "Name", animalEmployee.AnimalId);
            ViewData["EmployeeId"] = new SelectList(_context.Employee, "EmployeeId", "Name", animalEmployee.EmployeeId);
            return View(animalEmployee);
        }

        // POST: AnimalEmployees/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin,Employee")]
        public async Task<IActionResult> Edit(int id, [Bind("AnimalEmployeeId,EmployeeId,AnimalId")] AnimalEmployee animalEmployee)
        {
            if (id != animalEmployee.AnimalEmployeeId)
            {
                return NotFound();
            }

            if (!ModelState.IsValid)
            {
                try
                {
                    _context.Update(animalEmployee);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AnimalEmployeeExists(animalEmployee.AnimalEmployeeId))
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
            ViewData["AnimalId"] = new SelectList(_context.Animal, "AnimalId", "Name", animalEmployee.AnimalId);
            ViewData["EmployeeId"] = new SelectList(_context.Employee, "EmployeeId", "Name", animalEmployee.EmployeeId);
            return View(animalEmployee);
        }

        // GET: AnimalEmployees/Delete/5
        [Authorize(Roles = "Admin,Employee")]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var animalEmployee = await _context.AnimalEmployee
                .Include(a => a.Animal)
                .Include(a => a.Employee)
                .FirstOrDefaultAsync(m => m.AnimalEmployeeId == id);
            if (animalEmployee == null)
            {
                return NotFound();
            }

            return View(animalEmployee);
        }

        // POST: AnimalEmployees/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin,Employee")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var animalEmployee = await _context.AnimalEmployee.FindAsync(id);
            if (animalEmployee != null)
            {
                _context.AnimalEmployee.Remove(animalEmployee);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AnimalEmployeeExists(int id)
        {
            return _context.AnimalEmployee.Any(e => e.AnimalEmployeeId == id);
        }
    }
}
