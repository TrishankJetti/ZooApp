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
    [Authorize] // Ensures that only authenticated or signed in users can access actions in this controller
    public class VisitorsController : Controller
    {
        private readonly ZooAppContext _context;
        private readonly UserManager<ApplicationUser> _userManager;

        // Constructor to inject dependencies such as the context and the UserManager from Identity.
        public VisitorsController(ZooAppContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        // GET: Visitors/Index

        // Handles displaying a paginated list of visitors with search and sorting capabilities
        public async Task<IActionResult> Index(string searchString, string sortOrder, int? pageNumber, bool isSearch = false)
        {
            ViewData["VisitorNameFilter"] = searchString; // Search view 
            ViewData["CurrentSort"] = sortOrder;   // Current sort view, that tell the pagiantion what type of sort is currently taking palce so the pagination can do its job accordingly.
            ViewData["NameSortParm"] = string.IsNullOrEmpty(sortOrder) ? "name_desc" : ""; //NAme sorting view

            var userId = _userManager.GetUserId(User); // Get the current user's ID

            // Only, shows visitors the the user has created.
            var visitors = _context.Visitor
                .Where(v => v.CreatedByUserId == userId)
                .AsQueryable();

            // Apply search filter if searchString is not empty
            if (!string.IsNullOrEmpty(searchString))
            {
                visitors = visitors.Where(v => v.Name.Contains(searchString) || v.Email.Contains(searchString));
                isSearch = true; // Mark that the user has searched for something. I have created this variable to ensure that the No Results! page only comes up when the User has searcehd for something, not when they haven't created any visitors.
            }

            // Apply sorting based on sortOrder parameter
            switch (sortOrder)
            {
                case "name_desc": // This case in switch makes sure that the Name is descending .
                    visitors = visitors.OrderByDescending(v => v.Name);
                    break;
                default: //This case is default meaning that when the website is launched the visitors wil leb ordered by Name in ascending order.
                    visitors = visitors.OrderBy(v => v.Name);
                    break;
            }

            // Pagination setup
            int pageSize = 4; // Number of visitors per page which is 4.
            var paginatedVisitors = await PaginatedList<Visitor>.CreateAsync(visitors.AsNoTracking(), pageNumber ?? 1, pageSize);

            // If it's a search and no visitors match the criteria, redirect to NoVisitors action which basically returns a view telling the user that there isnt any results that that contain their query.
            if (isSearch== true && !paginatedVisitors.Any())
            {
                return RedirectToAction("NoVisitors");
            }

            // Show the paginated list of visitors.
            return View(paginatedVisitors);
        }

        // NoVisitors action to handle cases where no visitors match the search criteria
        public IActionResult NoVisitors()
        {
            return View();
        }

        // GET: Visitors/Details/5
        // Displays details of a specific visitor
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound(); // Return 404 if id is null
            }

            var userId = _userManager.GetUserId(User); // Gets the current user's ID
            var visitor = await _context.Visitor
                .FirstOrDefaultAsync(m => m.VisitorId == id && m.CreatedByUserId == userId); // Fetch visitor by id and user ID

            if (visitor == null)
            {
                return NotFound(); // Return 404 if visitor is not found or doesn't belong to the current user
            }

            return View(visitor); // Return the visitor details view
        }

        // GET: Visitors/Create

        // Displays the form to create a new visitor
        public IActionResult Create()
        {
            return View();
        }

        // POST: Visitors/Create

        // Handles the creation of a new visitor
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("VisitorId,Name,Email,Phone,Address")] Visitor visitor)
        {
            var userId = _userManager.GetUserId(User); // Get the current user's ID
            visitor.CreatedByUserId = userId; // Set the creator's user ID for the new visitor

            if (!ModelState.IsValid)
            {
                _context.Add(visitor); // Adds the new visitor to the context
                await _context.SaveChangesAsync(); // Save changes asynchronously
                return RedirectToAction(nameof(Index)); // Redirect to the index action
            }

            return View(visitor); // Return the visitor view
        }

        // GET: Visitors/Edit/5
        // Displays the form to edit a visitor
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound(); // Return 404 if id is null
            }

            var userId = _userManager.GetUserId(User); // Get the current user's ID

            // Find the visitor by id and ensure it belongs to the current user
            var visitor = await _context.Visitor
                .FirstOrDefaultAsync(m => m.VisitorId == id && m.CreatedByUserId == userId);

            if (visitor == null)
            {
                return NotFound(); // Return 404 if visitor is not found or doesn't belong to the current user
            }

            return View(visitor); // Return the visitor edit view
        }

        // POST: Visitors/Edit/5
        // Handles updating a visitor
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("VisitorId,Name,Email,Phone,Address,CreatedByUserId")] Visitor visitor)
        {
            if (id != visitor.VisitorId)
            {
                return NotFound(); // Return 404 if id doesn't match visitorId
            }

            var userId = _userManager.GetUserId(User); // Get the current user's ID

            // Ensure the visitor exists and belongs to the current user
            var existingVisitor = await _context.Visitor.FindAsync(id);
            if (existingVisitor == null || existingVisitor.CreatedByUserId != userId)
            {
                return NotFound(); // Return 404 if visitor is not found or doesn't belong to the current user
            }

            // Updates only the allowed properties as the User shouldnt be allowed to edit their VisitorID as it would result in duplicate data if they had two records with same id, which is the unique identifier.
            existingVisitor.Name = visitor.Name;
            existingVisitor.Email = visitor.Email;
            existingVisitor.Phone = visitor.Phone;
            existingVisitor.Address = visitor.Address;

            if (!ModelState.IsValid)
            {
                try
                {
                    _context.Update(existingVisitor); // Update the existing visitor in the context
                    await _context.SaveChangesAsync(); // Save changes asynchronously
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!VisitorExists(visitor.VisitorId))
                    {
                        return NotFound(); // Return 404 if visitor doesn't exist
                    }
                    else
                    {
                        throw; // Throw exception for other concurrency issues
                    }
                }
                return RedirectToAction(nameof(Index)); // Redirect to the index action
            }

            return View(visitor); // Return the visitor view
        }

        // GET: Visitors/Delete/5
        // Displays the form to delete a visitor
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound(); // Return 404 if id is null
            }

            var userId = _userManager.GetUserId(User); // Get the current user's ID
            var visitor = await _context.Visitor
                .FirstOrDefaultAsync(m => m.VisitorId == id && m.CreatedByUserId == userId); // Fetch visitor by id and user ID

            if (visitor == null)
            {
                return NotFound(); // Return 404 if visitor is not found or doesn't belong to the current user
            }

            return View(visitor); // Return the visitor delete view
        }

        // POST: Visitors/Delete/5
        // Handles deleting a visitor
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var userId = _userManager.GetUserId(User); // Get the current user's ID
            var visitor = await _context.Visitor.FindAsync(id); // Find visitor by id

            if (visitor == null || visitor.CreatedByUserId != userId)
            {
                return Unauthorized(); // Return unauthorized if visitor doesn't exist or doesn't belong to the current user
            }

            _context.Visitor.Remove(visitor); // Remove visitor from the context
            await _context.SaveChangesAsync(); // Save changes asynchronously
            return RedirectToAction(nameof(Index)); // Redirect to the index action
        }

        // Check if a visitor exists based on id
        private bool VisitorExists(int id)
        {
            return _context.Visitor.Any(e => e.VisitorId == id); // Returns true if visitor exists within the database.
        }
    }
}
