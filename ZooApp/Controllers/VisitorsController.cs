using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ZooApp.Data;
using ZooApp.Models;
using System.Linq;
using System.Threading.Tasks;
using ZooApp.data;

namespace ZooApp.Controllers
{
    [Authorize]
    public class VisitorsController : Controller
    {
        public async Task<IActionResult> Quiz()
        {


            return View();
        }
        private readonly ZooAppContext _context;
        private readonly UserManager<ApplicationUser> _userManager;

        public VisitorsController(ZooAppContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        // GET: Visitors/Index
        public async Task<IActionResult> Index(string searchString, string sortOrder, int? pageNumber, bool isSearch = false)
        {
            ViewData["VisitorNameFilter"] = searchString;
            ViewData["CurrentSort"] = sortOrder;
            ViewData["NameSortParm"] = string.IsNullOrEmpty(sortOrder) ? "name_desc" : "";

            var userId = _userManager.GetUserId(User);

            var visitors = _context.Visitor
                .Where(v => v.CreatedByUserId == userId)
                .AsQueryable();

            // Apply search filter
            if (!string.IsNullOrEmpty(searchString))
            {
                visitors = visitors.Where(v => v.Name.Contains(searchString) || v.Email.Contains(searchString));
                isSearch = true; // Mark that a search has been performed
            }

            // Apply sorting
            switch (sortOrder)
            {
                case "name_desc":
                    visitors = visitors.OrderByDescending(v => v.Name);
                    break;
                default:
                    visitors = visitors.OrderBy(v => v.Name);
                    break;
            }

            // Pagination setup
            int pageSize = 4; // one page may show up to 3 records.
            var paginatedVisitors = await PaginatedList<Visitor>.CreateAsync(visitors.AsNoTracking(), pageNumber ?? 1, pageSize);

            // Code checks if there is any visitors left after the search and filter.
            if (isSearch && !paginatedVisitors.Any())
            {
                return RedirectToAction("NoVisitors");
            }

            // Show the normal index view if not a search or if there are results
            return View(paginatedVisitors);
        }

        // NoResults action
        public IActionResult NoVisitors()
        {
            return View();
        }





        // GET: Visitors/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userId = _userManager.GetUserId(User);
            var visitor = await _context.Visitor
                .FirstOrDefaultAsync(m => m.VisitorId == id && m.CreatedByUserId == userId);

            if (visitor == null)
            {
                return NotFound();
            }

            return View(visitor);
        }

        // GET: Visitors/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Visitors/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("VisitorId,Name,Email,Phone,Address")] Visitor visitor)
        {
            var userId = _userManager.GetUserId(User);
            visitor.CreatedByUserId = userId;

            if (!ModelState.IsValid)
            {
                _context.Add(visitor);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(visitor);
        }


        // GET: Visitors/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userId = _userManager.GetUserId(User);

            // Find the visitor by id and ensure it belongs to the current user
            var visitor = await _context.Visitor
                .FirstOrDefaultAsync(m => m.VisitorId == id && m.CreatedByUserId == userId);

            if (visitor == null)
            {
                return NotFound();
            }

            return View(visitor);
        }

        // POST: Visitors/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("VisitorId,Name,Email,Phone,Address,CreatedByUserId")] Visitor visitor)
        {
            if (id != visitor.VisitorId)
            {
                return NotFound();
            }

            var userId = _userManager.GetUserId(User);

            // Ensures the visitor exists and belongs to the current user
            var existingVisitor = await _context.Visitor.FindAsync(id);
            if (existingVisitor == null || existingVisitor.CreatedByUserId != userId)
            {
                return NotFound();
            }

            // Updates only the allowed properties
            existingVisitor.Name = visitor.Name;
            existingVisitor.Email = visitor.Email;
            existingVisitor.Phone = visitor.Phone;
            existingVisitor.Address = visitor.Address;

            if (!ModelState.IsValid)
            {
                try
                {
                    _context.Update(existingVisitor);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!VisitorExists(visitor.VisitorId))
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
            return View(visitor);
        }


        // GET: Visitors/Delete/5

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userId = _userManager.GetUserId(User);
            var visitor = await _context.Visitor
                .FirstOrDefaultAsync(m => m.VisitorId == id && m.CreatedByUserId == userId);

            if (visitor == null)
            {
                return NotFound();
            }

            return View(visitor);
        }

        // POST: Visitors/Delete/5
        
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var userId = _userManager.GetUserId(User);
            var visitor = await _context.Visitor.FindAsync(id);

            if (visitor == null || visitor.CreatedByUserId != userId)
            {
                return Unauthorized();
            }

            _context.Visitor.Remove(visitor);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool VisitorExists(int id)
        {
            return _context.Visitor.Any(e => e.VisitorId == id);
        }
    }
}
