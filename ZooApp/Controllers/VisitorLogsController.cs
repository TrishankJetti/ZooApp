using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ZooApp.Models;
using ZooApp.data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;

namespace ZooApp.Controllers
{
   
    public class VisitorLogsController : Controller
    {
        public async Task<IActionResult> Quiz()
        {


            return View();
        }

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
            var userId = _userManager.GetUserId(User);
            ViewBag.CurrentUserId = userId;

            var zooAppContext = _context.VisitorLogs.Include(v => v.Visitor);
            return View(await zooAppContext.ToListAsync());
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
        [Authorize]
        public async Task<IActionResult> Create()
        {
            var userId = _userManager.GetUserId(User);

            // Filter the visitors to those created by the current user
            var visitors = await _context.Visitor
                .Where(v => v.CreatedByUserId == userId)
                .Select(v => new SelectListItem
                {
                    Text = v.Name,
                    Value = v.VisitorId.ToString()
                })
                .ToListAsync();

            ViewData["VisitorId"] = new SelectList(visitors, "Value", "Text");
            return View();
        }

        // POST: VisitorLogs/Create
        [HttpPost]
        [Authorize]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("VisitorLogId,VisitorId,DateVisited,Comments")] VisitorLog visitorLog)
        {
            var userId = _userManager.GetUserId(User);

            // Check if the visitor belongs to the current user
            var visitor = await _context.Visitor
                .FirstOrDefaultAsync(v => v.VisitorId == visitorLog.VisitorId && v.CreatedByUserId == userId);

            if (visitor == null)
            {
                return Unauthorized(); // Return an unauthorized response if visitor is not created by the user
            }

            if (!ModelState.IsValid)
            {
                visitorLog.CreatedOn = DateTime.Now; // Set CreatedOn value to today's date
                _context.Add(visitorLog);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            // Re-populate the visitors dropdown in case of model errors
            var visitors = await _context.Visitor
                .Where(v => v.CreatedByUserId == userId)
                .Select(v => new SelectListItem
                {
                    Text = v.Name,
                    Value = v.VisitorId.ToString()
                })
                .ToListAsync();

            ViewData["VisitorId"] = new SelectList(visitors, "Value", "Text", visitorLog.VisitorId);
            return View(visitorLog);
        }

        // GET: VisitorLogs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userId = _userManager.GetUserId(User);

            var visitorLog = await _context.VisitorLogs
                .Include(v => v.Visitor)
                .FirstOrDefaultAsync(m => m.VisitorLogId == id && m.Visitor.CreatedByUserId == userId);

            if (visitorLog == null)
            {
                return NotFound();
            }

            ViewData["VisitorId"] = new SelectList(_context.Visitor, "VisitorId", "Name", visitorLog.VisitorId);
            return View(visitorLog);
        }
        // POST: VisitorLogs/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("VisitorLogId,VisitorId,Comments,Review,CreatedOn")] VisitorLog visitorLog)
        {
            if (id != visitorLog.VisitorLogId)
            {
                return NotFound();
            }

            var userId = _userManager.GetUserId(User);

            var existingVisitorLog = await _context.VisitorLogs
                .Include(v => v.Visitor)
                .FirstOrDefaultAsync(m => m.VisitorLogId == id && m.Visitor.CreatedByUserId == userId);

            if (existingVisitorLog == null)
            {
                return NotFound();
            }

            // Update existingVisitorLog with new values
            existingVisitorLog.VisitorId = visitorLog.VisitorId;
            existingVisitorLog.Comments = visitorLog.Comments;
            existingVisitorLog.Review = visitorLog.Review;

            try
            {
                _context.Update(existingVisitorLog);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
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
        }




        // GET: VisitorLogs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userId = _userManager.GetUserId(User);

            var visitorLog = await _context.VisitorLogs
                .Include(v => v.Visitor)
                .Where(m => m.VisitorLogId == id && m.Visitor.CreatedByUserId == userId) // Correct filtering
                .FirstOrDefaultAsync();

            if (visitorLog == null)
            {
                return Unauthorized(); // Unauthorized if the visitor log is not associated with the user's visitor
            }

            return View(visitorLog);
        }

        // POST: VisitorLogs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var userId = _userManager.GetUserId(User);

            var visitorLog = await _context.VisitorLogs
                .Include(v => v.Visitor)
                .Where(m => m.VisitorLogId == id && m.Visitor.CreatedByUserId == userId) // Correct filtering
                .FirstOrDefaultAsync();

            if (visitorLog == null)
            {
                return Unauthorized(); // Unauthorized if the visitor log is not associated with the user's visitor
            }

            _context.VisitorLogs.Remove(visitorLog);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool VisitorLogExists(int id)
        {
            return _context.VisitorLogs.Any(e => e.VisitorLogId == id);
        }
    }
}
