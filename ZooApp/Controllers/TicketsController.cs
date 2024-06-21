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
using Microsoft.AspNetCore.Identity;

namespace ZooApp.Controllers
{
    [Authorize]
    public class TicketsController : Controller
    {
        public async Task<IActionResult> Quiz()
        {


            return View();
        }
        private readonly ZooAppContext _context;
        private readonly UserManager<ApplicationUser> _userManager;
        public TicketsController(ZooAppContext context , UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        // GET: Tickets
        public async Task<IActionResult> Index()
        {
            var zooAppContext = _context.Ticket.Include(t => t.Event).Include(t => t.Visitor);
            return View(await zooAppContext.ToListAsync());
        }


        // GET: Tickets/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ticket = await _context.Ticket
                .Include(t => t.Event)
                .Include(t => t.Visitor)
                .FirstOrDefaultAsync(m => m.TicketId == id);
            if (ticket == null)
            {
                return NotFound();
            }

            return View(ticket);
        }

        // GET: Tickets/Create
      
        public IActionResult Create()
        {
            var userId = _userManager.GetUserId(User);

            // Query visitors created by the current user
            var visitors = _context.Visitor
             .Where(v => v.CreatedByUserId == userId).Select(v => new SelectListItem { 
             Text = v.Name,
             Value = v.VisitorId.ToString()
               
             })
             .ToList();

            ViewData["EventId"] = new SelectList(_context.Event, "EventId", "Name"); // Use Event Name
            ViewData["VisitorId"] = new SelectList(visitors, "Value", "Text"); // Use Visitor Name
            return View();
        }

        // POST: Tickets/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        
        public async Task<IActionResult> Create([Bind("TicketId,DateOfPurchase,EventId,VisitorId")] Ticket ticket)
        {
            if ( ModelState.IsValid)
            {
                ViewData["EventId"] = new SelectList(_context.Event, "EventId", "Name", ticket.EventId); // Use Event Name

                var userId = _userManager.GetUserId(User);

                // Query visitors created by the current user
                var visitors = _context.Visitor
                .Where(v => v.CreatedByUserId == userId).Select(v => new SelectListItem {
               Text = v.Name,
               Value = v.VisitorId.ToString()
               })
               .ToList();

                ViewData["VisitorId"] = new SelectList(visitors, "Value", "Text", ticket.VisitorId); // Use Visitor Name
                return View(ticket);
            }

            // Ensure the VisitorId belongs to the current user if condition isnt met then the user will be unauthorized
            var visitor = await _context.Visitor.FindAsync(ticket.VisitorId);
            if (visitor == null || visitor.CreatedByUserId != _userManager.GetUserId(User))
            {
                return Unauthorized();
            }

            _context.Add(ticket);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }



        // GET: Tickets/Edit/5
        
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userId = _userManager.GetUserId(User);

            var ticket = await _context.Ticket
                .Include(t => t.Event)
                .Include(t => t.Visitor)
                .FirstOrDefaultAsync(t => t.TicketId == id && t.Visitor.CreatedByUserId == userId);

            if (ticket == null)
            {
                return NotFound();
            }

            ViewData["EventId"] = new SelectList(_context.Event, "EventId", "Name", ticket.EventId);

            // Query visitors created by the current user
            var visitors = _context.Visitor
                .Where(v => v.CreatedByUserId == userId)
                .Select(v => new SelectListItem
                {
                    Text = v.Name,
                    Value = v.VisitorId.ToString(),
                    Selected = v.VisitorId == ticket.VisitorId // Pre-select the current ticket's visitor
                })
                .ToList();

            ViewData["VisitorId"] = new SelectList(visitors, "Value", "Text");

            return View(ticket);
        }


        // POST: Tickets/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
       
        public async Task<IActionResult> Edit(int id, [Bind("TicketId,DateOfPurchase,EventId,VisitorId")] Ticket ticket)
        {
            if (id != ticket.TicketId)
            {
                return NotFound();
            }

            var userId = _userManager.GetUserId(User);

            var existingTicket = await _context.Ticket
                .Include(t => t.Visitor)
                .FirstOrDefaultAsync(t => t.TicketId == id && t.Visitor.CreatedByUserId == userId);

            if (existingTicket == null)
            {
                return NotFound();
            }

            if (!ModelState.IsValid)
            {
                try
                {
                    // Ensure the VisitorId belongs to the current user
                    var visitor = await _context.Visitor.FindAsync(ticket.VisitorId);
                    if (visitor == null || visitor.CreatedByUserId != userId)
                    {
                        return Unauthorized();
                    }

                    existingTicket.DateOfPurchase = ticket.DateOfPurchase;
                    existingTicket.EventId = ticket.EventId;
                    existingTicket.VisitorId = ticket.VisitorId;

                    _context.Update(existingTicket);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TicketExists(ticket.TicketId))
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

            ViewData["EventId"] = new SelectList(_context.Event, "EventId", "Name", ticket.EventId);

            // Query visitors created by the current user
            var visitors = _context.Visitor
                .Where(v => v.CreatedByUserId == userId)
                .Select(v => new SelectListItem
                {
                    Text = v.Name,
                    Value = v.VisitorId.ToString(),
                    Selected = v.VisitorId == ticket.VisitorId // Pre-select the current ticket's visitor
                })
                .ToList();

            ViewData["VisitorId"] = new SelectList(visitors, "Value", "Text", ticket.VisitorId);

            return View(ticket);
        }


        // GET: Tickets/Delete/5
        
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ticket = await _context.Ticket
                .Include(t => t.Event)
                .Include(t => t.Visitor)
                .FirstOrDefaultAsync(m => m.TicketId == id);
            if (ticket == null)
            {
                return NotFound();
            }

            return View(ticket);
        }

        // POST: Tickets/Delete/5
        [HttpPost, ActionName("Delete")]
        
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var ticket = await _context.Ticket.FindAsync(id);
            if (ticket != null)
            {
                _context.Ticket.Remove(ticket);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TicketExists(int id)
        {
            return _context.Ticket.Any(e => e.TicketId == id);
        }
    }
}
