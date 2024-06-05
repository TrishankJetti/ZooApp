using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using ZooApp.data;
using ZooApp.Data;
using ZooApp.Models;

namespace ZooApp.Controllers
{
    public class EmployeesController : Controller
    {
        private readonly ZooAppContext _context;
        private readonly IWebHostEnvironment _hostEnvironment;

        public EmployeesController(ZooAppContext context, IWebHostEnvironment hostEnvironment)
        {
            _context = context;
            _hostEnvironment = hostEnvironment;
        }

        // GET: Employees
        public async Task<IActionResult> Index(string searchString)
        {
            ViewData["EmployeeNameFilter"] = searchString;
            var employees = from e in _context.Employee.Include(e => e.Enclosure)
                            select e;

            if (!String.IsNullOrEmpty(searchString))
            {
                employees = employees.Where(e => e.Name.Contains(searchString));
            }

            return View(await employees.ToListAsync());
        }

        // GET: Employees/Details/5
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employee = await _context.Employee
                .Include(e => e.Enclosure)
                .FirstOrDefaultAsync(m => m.EmployeeId == id);
            if (employee == null)
            {
                return NotFound();
            }

            return View(employee);
        }

        // GET: Employees/Create
        [Authorize(Roles = "Admin")]
        public IActionResult Create()
        {
            ViewData["EnclosureId"] = new SelectList(_context.Enclosure, "EnclosureId", "Name");
            return View();
        }

        // POST: Employees/Create
        [HttpPost]
        [Authorize(Roles = "Admin")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("EmployeeId,Name,Role,Phone,Salary,HireDate,EnclosureId")] Employee employee)
        {
            if (!ModelState.IsValid) // Fix condition to check if model state is valid
            {
                // Handle file upload
                if (@employee.ImageFile != null)
                {
                    string fileName = Path.GetFileNameWithoutExtension(@employee.ImageFile.FileName);
                    string extension = Path.GetExtension(@employee.ImageFile.FileName);
                    employee.ImageFileName = fileName = fileName + DateTime.Now.ToString("yymmssfff") + extension;
                    string path = Path.Combine(_hostEnvironment.WebRootPath, "images", fileName);
                    using (var fileStream = new FileStream(path, FileMode.Create))
                    {
                        await @employee.ImageFile.CopyToAsync(fileStream);
                    }
                }
                _context.Add(employee);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["EnclosureId"] = new SelectList(_context.Enclosure, "EnclosureId", "Name", employee.EnclosureId);
            return View(employee);
        }

        // GET: Employees/Edit/5
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employee = await _context.Employee.FindAsync(id);
            if (employee == null)
            {
                return NotFound();
            }
            ViewData["EnclosureId"] = new SelectList(_context.Enclosure, "EnclosureId", "Name", employee.EnclosureId);
            return View(employee);
        }

        // POST: Employees/Edit/5
        [HttpPost]
        [Authorize(Roles = "Admin")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("EmployeeId,Name,Role,Phone,Salary,HireDate,EnclosureId")] Employee employee)
        {
            if (id != employee.EmployeeId)
            {
                return NotFound();
            }

            if (!ModelState.IsValid)
            {
                try
                {
                    _context.Update(employee);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EmployeeExists(employee.EmployeeId))
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
            ViewData["EnclosureId"] = new SelectList(_context.Enclosure, "EnclosureId", "Name", employee.EnclosureId);
            return View(employee);
        }

        // GET: Employees/Delete/5
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employee = await _context.Employee
                .FirstOrDefaultAsync(m => m.EmployeeId == id);
            if (employee == null)
            {
                return NotFound();
            }

            return View(employee);
        }

        // POST: Employees/Delete/5
        [HttpPost, ActionName("Delete")]
        [Authorize(Roles = "Admin")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var employee = await _context.Employee.FindAsync(id);
            if (employee == null)
            {
                return NotFound();
            }

            // Update references in the Animal table
            var animals = await _context.Animal.Where(a => a.EmployeeId == id).ToListAsync();
            foreach (var animal in animals)
            {
                animal.EmployeeId = null; // Remove association
            }

            _context.Employee.Remove(employee);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EmployeeExists(int id)
        {
            return _context.Employee.Any(e => e.EmployeeId == id);
        }
    }
}
