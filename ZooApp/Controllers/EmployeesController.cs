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
        public async Task<IActionResult> Index(string searchString, string roleType, string sortOrder, string currentRoleType, int? pageNumber, string currentFilter)
        {
            // Store filters and sort orders in ViewData for use in the view
            ViewData["EmployeeNameFilter"] = searchString;
            ViewData["RoleTypeFilter"] = string.IsNullOrEmpty(roleType) ? currentRoleType : roleType;
            ViewData["CurrentSort"] = sortOrder;
            ViewData["NameSortParm"] = string.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            ViewData["RoleSortParm"] = sortOrder == "Role" ? "role_desc" : "Role";
            ViewData["HireDateSortParm"] = sortOrder == "HireDate" ? "hiredate_desc" : "HireDate";

            // Reset page number if search string changes
            if (searchString != null)
            {
                pageNumber = 1;
            }
            else
            {
                searchString = currentFilter;
            }

            // Store current filter in ViewData
            ViewData["CurrentFilter"] = searchString;

            // Query to get all employees including their enclosure information
            var employees = _context.Employee.Include(e => e.Enclosure).AsQueryable();

            // Filter by search string (Name)
            if (!string.IsNullOrEmpty(searchString))
            {
                employees = employees.Where(e => e.Name.Contains(searchString));
            }

            // Filter by role type
            if (!string.IsNullOrEmpty(roleType))
            {
                employees = employees.Where(e => e.Role == Enum.Parse<RoleType>(roleType));
            }

            // Sorting
            switch (sortOrder)
            {
                case "name_desc":
                    employees = employees.OrderByDescending(e => e.Name);
                    break;
                case "Role":
                    employees = employees.OrderBy(e => e.Role);
                    break;
                case "role_desc":
                    employees = employees.OrderByDescending(e => e.Role);
                    break;
                case "HireDate":
                    employees = employees.OrderBy(e => e.HireDate);
                    break;
                case "hiredate_desc":
                    employees = employees.OrderByDescending(e => e.HireDate);
                    break;
                default:
                    employees = employees.OrderBy(e => e.Name);
                    break;
            }

            // Pagination
            int pageSize = 3;
            return View(await PaginatedList<Employee>.CreateAsync(employees.AsNoTracking(), pageNumber ?? 1, pageSize));
        }


        // GET: Employees/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employee = await _context.Employee
                .Include(e => e.AnimalEmployees)
                    .ThenInclude(ae => ae.Animal)
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
        // POST: Employees/Edit/5
        [HttpPost]
        [Authorize(Roles = "Admin,Employee")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("EmployeeId,Name,Role,Phone,Salary,HireDate,EnclosureId,ImageFile,ImageFileName")] Employee employee)
        {
            if (id != employee.EmployeeId)
            {
                return NotFound();
            }

      

            if (!ModelState.IsValid)
            {
                try
                {
                    // Retrieve the existing employee entity without tracking
                    var existingEmployee = await _context.Employee
                        .FirstOrDefaultAsync(e => e.EmployeeId == id);

                    if (existingEmployee == null)
                    {
                        return NotFound();
                    }

                    // Update specific properties only as mentioned above this prevents the duplicate tracking error from occuring.
                    existingEmployee.Name = employee.Name;
                    existingEmployee.Role = employee.Role;
                    existingEmployee.Phone = employee.Phone;
                    existingEmployee.Salary = employee.Salary;
                    existingEmployee.HireDate = employee.HireDate;
                    existingEmployee.EnclosureId = employee.EnclosureId;

                    // Handle image file update if a new file is uploaded
                    if (employee.ImageFile != null && employee.ImageFile.Length > 0)
                    {
                        

                        // Generate a unique file name for the new image
                        string uploadsFolder = Path.Combine(_hostEnvironment.WebRootPath, "images");
                        string uniqueFileName = Guid.NewGuid().ToString() + "_" + employee.ImageFile.FileName;
                        string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                        using (var fileStream = new FileStream(filePath, FileMode.Create))
                        {
                            await employee.ImageFile.CopyToAsync(fileStream);
                        }
                        existingEmployee.ImageFileName = uniqueFileName;
                    }
                    else if (string.IsNullOrEmpty(employee.ImageFileName))
                    {
                        // If no new ImageFile is provided and ImageFileName is null or empty,
                        // set it to the existing ImageFileName to maintain the current image
                        existingEmployee.ImageFileName = existingEmployee.ImageFileName;
                    }

                    // Update the entity in the database
                    _context.Update(existingEmployee);
                    await _context.SaveChangesAsync();

                    return RedirectToAction(nameof(Index));
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
            }

            // If ModelState is not valid, reload necessary data and return to the view with errors
            ViewData["EnclosureId"] = new SelectList(_context.Enclosure, "EnclosureId", "Name", employee.EnclosureId);
            return View(employee);
        }

      


        // Helper method to delete old image file if a new one is uploaded
        private void DeleteOldImage(string fileName)
        {
            if (!string.IsNullOrEmpty(fileName))
            {
                string filePath = Path.Combine(_hostEnvironment.WebRootPath, "images", fileName);
                if (System.IO.File.Exists(filePath))
                {
                    System.IO.File.Delete(filePath);
                }
            }
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
            if (employee == null)
            {
                return NotFound();
            }

            // Fetches all animals associated with this employee
            var animalsWithEmployee = _context.Animal.Where(a => a.EmployeeId == id).ToList();

            // Sets EmployeeId to null for associated animals
            foreach (var animal in animalsWithEmployee)
            {
                animal.EmployeeId = null; 
            }

            // Remove the employee
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
