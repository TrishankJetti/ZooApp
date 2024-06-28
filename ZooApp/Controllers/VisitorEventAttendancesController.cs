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
    //This is the controller for the junction table in the Visitors and events, as many visitors can visit many events. I ahven't changed anything in this controller and left it as default.
    public class VisitorEventAttendancesController : Controller
    {
        private readonly ZooAppContext _context;

        public VisitorEventAttendancesController(ZooAppContext context)
        {
            _context = context;
        }

        // GET: VisitorEventAttendances
        [Authorize(Roles = "Admin , Employee")]
        public async Task<IActionResult> Index()
        {
            var zooAppContext = _context.VisitorEventAttendances.Include(v => v.Event).Include(v => v.Visitor);
            return View(await zooAppContext.ToListAsync());
        }

        // GET: VisitorEventAttendances/Details/5
        [Authorize(Roles = "Admin , Employee")]
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var visitorEventAttendance = await _context.VisitorEventAttendances
                .Include(v => v.Event)
                .Include(v => v.Visitor)
                .FirstOrDefaultAsync(m => m.VisitorEventAttendanceId == id);
            if (visitorEventAttendance == null)
            {
                return NotFound();
            }

            return View(visitorEventAttendance);
        }

        // GET: VisitorEventAttendances/Create
        [Authorize(Roles = "Admin , Employee")]
        public IActionResult Create()
        {
            ViewData["EventId"] = new SelectList(_context.Event, "EventId", "EventId");
            ViewData["VisitorId"] = new SelectList(_context.Visitor, "VisitorId", "VisitorId");
            return View();
        }

        // POST: VisitorEventAttendances/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [Authorize(Roles = "Admin , Employee")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("VisitorEventAttendanceId,VisitorId,EventId")] VisitorEventAttendance visitorEventAttendance)
        {
            if (!ModelState.IsValid)
            {
                _context.Add(visitorEventAttendance);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["EventId"] = new SelectList(_context.Event, "EventId", "EventId", visitorEventAttendance.EventId);
            ViewData["VisitorId"] = new SelectList(_context.Visitor, "VisitorId", "VisitorId", visitorEventAttendance.VisitorId);
            return View(visitorEventAttendance);
        }

        // GET: VisitorEventAttendances/Edit/5
        [Authorize(Roles = "Admin , Employee")]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var visitorEventAttendance = await _context.VisitorEventAttendances.FindAsync(id);
            if (visitorEventAttendance == null)
            {
                return NotFound();
            }
            ViewData["EventId"] = new SelectList(_context.Event, "EventId", "EventId", visitorEventAttendance.EventId);
            ViewData["VisitorId"] = new SelectList(_context.Visitor, "VisitorId", "VisitorId", visitorEventAttendance.VisitorId);
            return View(visitorEventAttendance);
        }

        // POST: VisitorEventAttendances/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin , Employee")]
        public async Task<IActionResult> Edit(int id, [Bind("VisitorEventAttendanceId,VisitorId,EventId")] VisitorEventAttendance visitorEventAttendance)
        {
            if (id != visitorEventAttendance.VisitorEventAttendanceId)
            {
                return NotFound();
            }

            if (!ModelState.IsValid)
            {
                try
                {
                    _context.Update(visitorEventAttendance);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!VisitorEventAttendanceExists(visitorEventAttendance.VisitorEventAttendanceId))
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
            ViewData["EventId"] = new SelectList(_context.Event, "EventId", "EventId", visitorEventAttendance.EventId);
            ViewData["VisitorId"] = new SelectList(_context.Visitor, "VisitorId", "VisitorId", visitorEventAttendance.VisitorId);
            return View(visitorEventAttendance);
        }

        // GET: VisitorEventAttendances/Delete/5
        [Authorize(Roles = "Admin , Employee")]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var visitorEventAttendance = await _context.VisitorEventAttendances
                .Include(v => v.Event)
                .Include(v => v.Visitor)
                .FirstOrDefaultAsync(m => m.VisitorEventAttendanceId == id);
            if (visitorEventAttendance == null)
            {
                return NotFound();
            }

            return View(visitorEventAttendance);
        }

        // POST: VisitorEventAttendances/Delete/5
        [Authorize(Roles = "Admin , Employee")]
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var visitorEventAttendance = await _context.VisitorEventAttendances.FindAsync(id);
            if (visitorEventAttendance != null)
            {
                _context.VisitorEventAttendances.Remove(visitorEventAttendance);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool VisitorEventAttendanceExists(int id)
        {
            return _context.VisitorEventAttendances.Any(e => e.VisitorEventAttendanceId == id);
        }
    }
}
