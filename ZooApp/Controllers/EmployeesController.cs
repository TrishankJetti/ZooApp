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
        public async Task<IActionResult> Index()
        {
            var employees = _context.Employee.Include(e => e.Enclosure);
            return View(await employees.ToListAsync());
        }

        // GET: Employees/Details/5
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
        public async Task<IActionResult> Create([Bind("EmployeeId,Name,Role,Phone,Salary,HireDate,EnclosureId,ImageFile")] Employee employee)
        {
            if (!ModelState.IsValid)
            {
                // Handle file upload
                if (employee.ImageFile != null)
                {
                    string fileName = Path.GetFileNameWithoutExtension(employee.ImageFile.FileName);
                    string extension = Path.GetExtension(employee.ImageFile.FileName);
                    employee.ImageFileName = $"{fileName}_{DateTime.Now:yyyyMMddHHmmssfff}{extension}";
                    string path = Path.Combine(_hostEnvironment.WebRootPath, "images", employee.ImageFileName);
                    using (var fileStream = new FileStream(path, FileMode.Create))
                    {
                        await employee.ImageFile.CopyToAsync(fileStream);
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
        public async Task<IActionResult> Edit(int id, [Bind("EmployeeId,Name,Role,Phone,Salary,HireDate,EnclosureId,ImageFileName,ImageFile")] Employee employee)
        {
            if (id != employee.EmployeeId)
            {
                return NotFound();
            }

            if (!ModelState.IsValid)
            {
                try
                {
                    // Handle file upload
                    if (employee.ImageFile != null)
                    {
                        string fileName = Path.GetFileNameWithoutExtension(employee.ImageFile.FileName);
                        string extension = Path.GetExtension(employee.ImageFile.FileName);
                        employee.ImageFileName = $"{fileName}_{DateTime.Now:yyyyMMddHHmmssfff}{extension}";
                        string path = Path.Combine(_hostEnvironment.WebRootPath, "images", employee.ImageFileName);
                        using (var fileStream = new FileStream(path, FileMode.Create))
                        {
                            await employee.ImageFile.CopyToAsync(fileStream);
                        }
                    }

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
                .Include(e => e.Enclosure)
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
            if (employee != null)
            {
                _context.Employee.Remove(employee);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EmployeeExists(int id)
        {
            return _context.Employee.Any(e => e.EmployeeId == id);
        }
    }
}
