using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ZooApp.Models;
using ZooApp.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using ZooApp.data;

namespace ZooApp.Controllers
{
    //This is the Controller for managing VisitorLogs
    public class VisitorLogsController : Controller
    {
        private readonly ZooAppContext _context; // DbContext for interacting with database
        private readonly UserManager<ApplicationUser> _userManager; // Identity UserManager for managing users similar to the Visitor Controller, we are injected Identity into this controller.

        // Constructor for VisitorLogsController
        public VisitorLogsController(ZooAppContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context; // Initialize ZooAppContext through dependency injection
            _userManager = userManager; // Initialize UserManager through dependency injection
        }

        // GET: VisitorLogs/Index
        public async Task<IActionResult> Index(string reviewFilter, string searchString)
        {
            var userId = _userManager.GetUserId(User); // Assuming you have UserManager injected

            // Retrieves all VisitorLogs including associated Visitor records.
            var visitorLogsQuery = _context.VisitorLogs.Include(vl => vl.Visitor).AsQueryable();

            // Apply filter based on the selected review type
            if (!string.IsNullOrEmpty(reviewFilter))
            {
                // Parses the selected review filter string to ReviewType enum
                var selectedReview = Enum.Parse<ReviewType>(reviewFilter);
                // Filter visitorLogsQuery to include only logs with the selected review type
                visitorLogsQuery = visitorLogsQuery.Where(v => v.Review == selectedReview);
            }

            // Apply search filter based on the visitor's name
            if (!string.IsNullOrEmpty(searchString))
            {
                visitorLogsQuery = visitorLogsQuery.Where(vl => vl.Visitor.Name.Contains(searchString));
            }

            var visitorLogs = await visitorLogsQuery.ToListAsync();

            // Count and pass the number of Visitors created by the current user to the view
            ViewData["VisitorCount"] = await _context.Visitor
                .Where(v => v.CreatedByUserId == userId)
                .CountAsync();

            ViewBag.CurrentUserId = userId; // Pass the current user's ID to ViewBag for view access
            ViewBag.ReviewFilter = reviewFilter; // Pass the current filter to ViewBag for view access
            ViewBag.SearchString = searchString; // Pass the current search string to ViewBag for view access

            if (!visitorLogs.Any())
            {
                return View("NoVisitorLogs");
            }

            return View(visitorLogs); // Return the list of VisitorLogs to the view
        }



        // GET: VisitorLogs/Details/5

        // Displays details of a specific VisitorLog
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound(); // Return NotFound if id is null
            }

            // Retrieve the VisitorLog with associated Visitor entity
            var visitorLog = await _context.VisitorLogs
                .Include(v => v.Visitor)
                .FirstOrDefaultAsync(m => m.VisitorLogId == id);

            if (visitorLog == null)
            {
                return NotFound(); // Return NotFound if VisitorLog is not found
            }

            return View(visitorLog); // Return the VisitorLog details to the view
        }

        // GET: VisitorLogs/Create
        // Displays form to create a new VisitorLog
        public IActionResult Create()
        {
            var userId = _userManager.GetUserId(User); // Get the current user's ID

            // Retrieve Visitors created by the current user so they may be prepopulated in the Viewbag that the form posseses.
            var visitors = _context.Visitor
                .Where(v => v.CreatedByUserId == userId)
                .ToList();

            // Redirect to Visitors Index if no visitors exist, as the user must create a visitor inorder to post a comment.
            if (!visitors.Any())
            {
                TempData["Message"] = "Please create a visitor first.";
                return RedirectToAction("Index", "Visitors");
            }

            // Pass list of visitors to the view for selection
            ViewData["VisitorId"] = new SelectList(visitors, "VisitorId", "Name");
            return View();
        }

        // POST: VisitorLogs/Create
        // Handles creation of a new VisitorLog
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("VisitorLogId,VisitorId,Comments,Review")] VisitorLog visitorLog)
        {
            if (!ModelState.IsValid)
            {
                visitorLog.CreatedOn = DateTime.Now; // Set creation date to the current date using DateTime.Now;.
                visitorLog.VisitorId = _context.Visitor
                    .Where(v => v.CreatedByUserId == _userManager.GetUserId(User))
                    .Select(v => v.VisitorId)
                    .FirstOrDefault(); // Set VisitorId based on current user

                _context.Add(visitorLog); // Add new VisitorLog to context
                await _context.SaveChangesAsync(); // Save changes to database
                return RedirectToAction(nameof(Index)); // Redirect to VisitorLogs Index after successful completion of the comment.
            }

            // Retrieve visitors created by the current user
            var visitors = _context.Visitor
                .Where(v => v.CreatedByUserId == _userManager.GetUserId(User))
                .ToList();

            // Pass list of visitors and current visitorLog data to view for correction
            ViewData["VisitorId"] = new SelectList(visitors, "VisitorId", "Name", visitorLog.VisitorId);
            return View(visitorLog); // Return to Create view with posted data
        }

        // GET: VisitorLogs/Edit/5
        // Displays form to edit an existing VisitorLog
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound(); // Return NotFound if id is null
            }

            // Retrieve the VisitorLog to edit
            var visitorLog = await _context.VisitorLogs.FindAsync(id);
            if (visitorLog == null)
            {
                return NotFound(); // Return NotFound if VisitorLog is not found
            }

            var userId = _userManager.GetUserId(User); // Get the current user's ID

            // Pass list of visitors created by the current user and current visitorLog details to view for editing
            ViewData["VisitorId"] = new SelectList(_context.Visitor
                .Where(v => v.CreatedByUserId == userId), "VisitorId", "Name", visitorLog.VisitorId);

            return View(visitorLog); // Return VisitorLog details to the view for editing
        }

        // POST: VisitorLogs/Edit/5
        // Handles update of an existing VisitorLog
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("VisitorLogId,VisitorId,Comments,Review,CreatedOn")] VisitorLog visitorLog)
        {
            if (id != visitorLog.VisitorLogId)
            {
                return NotFound(); // Return NotFound if id does not match visitorLog ID
            }

            if (ModelState.IsValid)
            {
                return View(visitorLog); // Return to view if model state is valid
            }

            try
            {
                // Retrieve the existing VisitorLog to edit
                var existingVisitorLog = await _context.VisitorLogs.FindAsync(id);
                if (existingVisitorLog == null)
                {
                    return NotFound(); // Return NotFound if VisitorLog is not found
                }

                var userId = _userManager.GetUserId(User); // Get the current user's ID


                visitorLog.ModifiedOn = DateTime.Now; // Set modification date to  current date.

                // Update fields of the existing VisitorLog to whatever the fields have been updated to contain in the create view of the form.
                existingVisitorLog.VisitorId = visitorLog.VisitorId;
                existingVisitorLog.Comments = visitorLog.Comments;
                existingVisitorLog.Review = visitorLog.Review;
                existingVisitorLog.ModifiedOn = visitorLog.ModifiedOn;

                _context.Update(existingVisitorLog); // Update existing VisitorLog in context
                await _context.SaveChangesAsync(); // Save changes to database
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!VisitorLogExists(visitorLog.VisitorLogId))
                {
                    return NotFound(); // Return NotFound if VisitorLog does not exist
                }
                else
                {
                    throw;
                }
            }

            return RedirectToAction(nameof(Index)); // Redirect to VisitorLogs Index after successful edit
        }

        // GET: VisitorLogs/Delete/5
        // Displays confirmation for deleting a VisitorLog
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound(); // Return NotFound if id is null
            }

            // Retrieve the VisitorLog to delete
            var visitorLog = await _context.VisitorLogs
                .Include(v => v.Visitor)
                .FirstOrDefaultAsync(m => m.VisitorLogId == id);

            if (visitorLog == null)
            {
                return NotFound(); // Return NotFound if VisitorLog is not found
            }

            var userId = _userManager.GetUserId(User); // Get the current user's ID

            // Check authorization to delete the VisitorLog
            if (visitorLog.Visitor.CreatedByUserId != userId)
            {
                return Forbid(); // Return Forbidden if user is not authorized to delete
            }

            return View(visitorLog); // Return VisitorLog details to view for confirmation
        }

        // POST: VisitorLogs/Delete/5
        // Handles deletion of a VisitorLog
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var visitorLog = await _context.VisitorLogs.FindAsync(id);
            if (visitorLog != null)
            {
                var userId = _userManager.GetUserId(User); // Get the current user's ID

                // Check authorization to delete the VisitorLog
                if (visitorLog.Visitor.CreatedByUserId != userId)
                {
                    return Forbid(); // Return Forbidden if user is not authorized to delete
                }

                _context.VisitorLogs.Remove(visitorLog); // Remove VisitorLog from context
                await _context.SaveChangesAsync(); // Save changes to database
            }

            return RedirectToAction(nameof(Index)); // Redirect to VisitorLogs Index after deletion
        }

        // Checks if a VisitorLog exists based on ID
        private bool VisitorLogExists(int id)
        {
            return _context.VisitorLogs.Any(e => e.VisitorLogId == id); // Returns true if VisitorLog indeed exists which results in the visitorlog being to get edited and etc.
        }
    }
}
