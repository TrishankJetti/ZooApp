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
    [Authorize]
    public class VisitorLogsController : Controller
    {
        private readonly ZooAppContext _context;

        public VisitorLogsController(ZooAppContext context)
        {
            _context = context;
        }

        // GET: VisitorLogs
        public async Task<IActionResult> Index()
        {
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
        public IActionResult Create()
        {
            ViewData["VisitorId"] = new SelectList(_context.Visitor, "VisitorId", "Name");
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
                _context.Add(visitorLog);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["VisitorId"] = new SelectList(_context.Visitor, "VisitorId", "Name", visitorLog.VisitorId);
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

            if (!ModelState.IsValid)
            {
                try
                {
                    _context.Update(visitorLog);
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
            ViewData["VisitorId"] = new SelectList(_context.Visitor, "VisitorId", "Name", visitorLog.VisitorId);
            return View(visitorLog);
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
