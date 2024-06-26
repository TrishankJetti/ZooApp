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
    [Authorize]
    public class VisitorLogsController : Controller
    {
        private readonly ZooAppContext _context;
        private readonly UserManager<ApplicationUser> _userManager;

        public VisitorLogsController(ZooAppContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }
        // GET: VisitorLogs
        public async Task<IActionResult> Index()
        {
            var userId = _userManager.GetUserId(User); // Get the current user's ID

            var visitorLogs = await _context.VisitorLogs
                .Include(vl => vl.Visitor)
                .ToListAsync();

            ViewData["VisitorCount"] = await _context.Visitor
                .Where(v => v.CreatedByUserId == userId)
                .CountAsync();

            ViewBag.CurrentUserId = userId;

            return View(visitorLogs); // Pass all visitorLogs to the view
        }

        // GET: VisitorLogs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var visitorLog = await _context.VisitorLogs
                .Include(v => v.Visitor)
                .FirstOrDefaultAsync(m => m.VisitorLogId == id);

            if (visitorLog == null)
            {
                return NotFound();
            }

            return View(visitorLog);
        }

        // GET: VisitorLogs/Create
        public IActionResult Create()
        {
            var userId = _userManager.GetUserId(User); // Get the current user's ID

            var visitors = _context.Visitor
                .Where(v => v.CreatedByUserId == userId)
                .ToList();

            if (!visitors.Any())
            {
                TempData["Message"] = "Please create a visitor first.";
                return RedirectToAction("Index", "Visitors");
            }

            ViewData["VisitorId"] = new SelectList(visitors, "VisitorId", "Name");
            return View();
        }

        // POST: VisitorLogs/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("VisitorLogId,VisitorId,Comments,Review")] VisitorLog visitorLog)
        {
            if (!ModelState.IsValid)
            {
                visitorLog.CreatedOn = DateTime.Now;
                visitorLog.VisitorId = _context.Visitor
                    .Where(v => v.CreatedByUserId == _userManager.GetUserId(User))
                    .Select(v => v.VisitorId)
                    .FirstOrDefault();

                _context.Add(visitorLog);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            var visitors = _context.Visitor
                .Where(v => v.CreatedByUserId == _userManager.GetUserId(User))
                .ToList();

            ViewData["VisitorId"] = new SelectList(visitors, "VisitorId", "Name", visitorLog.VisitorId);
            return View(visitorLog);
        }

        // GET: VisitorLogs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var visitorLog = await _context.VisitorLogs.FindAsync(id);
            if (visitorLog == null)
            {
                return NotFound();
            }

            // Check if the current user is authorized to edit this log
            var userId = _userManager.GetUserId(User); // Get the current user's ID


            ViewData["VisitorId"] = new SelectList(_context.Visitor
                .Where(v => v.CreatedByUserId == userId), "VisitorId", "Name", visitorLog.VisitorId);

            return View(visitorLog);
        }

        // POST: VisitorLogs/Edit/5
        // POST: VisitorLogs/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("VisitorLogId,VisitorId,Comments,Review,CreatedOn")] VisitorLog visitorLog)
        {
            if (id != visitorLog.VisitorLogId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                return View(visitorLog);
            }

            try
            {
                // Check if the current user is authorized to edit this log
                var existingVisitorLog = await _context.VisitorLogs.FindAsync(id);
                if (existingVisitorLog == null)
                {
                    return NotFound();
                }

                var userId = _userManager.GetUserId(User); // Get the current user's ID

                // Ensure that only one instance of the entity is tracked by detaching the existing one
                _context.Entry(existingVisitorLog).State = EntityState.Detached;

                visitorLog.ModifiedOn = DateTime.Now;

                // Update fields that can be modified
                existingVisitorLog.VisitorId = visitorLog.VisitorId;
                existingVisitorLog.Comments = visitorLog.Comments;
                existingVisitorLog.Review = visitorLog.Review;
                existingVisitorLog.ModifiedOn = visitorLog.ModifiedOn;

                _context.Update(existingVisitorLog);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!VisitorLogExists(visitorLog.VisitorLogId))
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


        // GET: VisitorLogs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var visitorLog = await _context.VisitorLogs
                .Include(v => v.Visitor)
                .FirstOrDefaultAsync(m => m.VisitorLogId == id);

            if (visitorLog == null)
            {
                return NotFound();
            }

            // Check if the current user is authorized to delete this log
            var userId = _userManager.GetUserId(User); // Get the current user's ID
            if (visitorLog.Visitor.CreatedByUserId != userId)
            {
                return Forbid(); // Or handle unauthorized access as needed
            }

            return View(visitorLog);
        }

        // POST: VisitorLogs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var visitorLog = await _context.VisitorLogs.FindAsync(id);
            if (visitorLog != null)
            {
                // Check if the current user is authorized to delete this log
                var userId = _userManager.GetUserId(User); // Get the current user's ID
                if (visitorLog.Visitor.CreatedByUserId != userId)
                {
                    return Forbid(); // Or handle unauthorized access as needed
                }

                _context.VisitorLogs.Remove(visitorLog);
                await _context.SaveChangesAsync();
            }

            return RedirectToAction(nameof(Index));
        }

        private bool VisitorLogExists(int id)
        {
            return _context.VisitorLogs.Any(e => e.VisitorLogId == id);
        }
    }
}
