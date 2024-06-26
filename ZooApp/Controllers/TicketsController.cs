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
using System.Drawing.Printing;
using System.Diagnostics.Metrics;

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

        // GET: Tickets/Index
        public async Task<IActionResult> Index(string searchString, string sortOrder, int? pageNumber)
        {
            ViewData["CurrentFilter"] = searchString;
            ViewData["NameSortParm"] = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            ViewData["DateSortParm"] = sortOrder == "Date" ? "date_desc" : "Date";
            ViewData["CurrentSort"] = sortOrder;

            var userId = _userManager.GetUserId(User); // Get the current user's ID

            // Gets all the visitors where the CreatedByUserId is equal to the particular signed in user's ID
            int visitorCount = await _context.Visitor
                                             .Where(v => v.CreatedByUserId == userId)
                                             .CountAsync();

            // Retrieve the tickets for the current user
            var ticketsQuery = _context.Ticket
                                       .Include(t => t.Visitor)
                                       .Include(t => t.Event)
                                       .Where(t => t.Visitor.CreatedByUserId == userId);

            // Apply search filter
            if (!String.IsNullOrEmpty(searchString))
            {
                ticketsQuery = ticketsQuery.Where(t => t.Visitor.Name.Contains(searchString) || t.Visitor.Email.Contains(searchString));
            }

            // Apply sorting
            switch (sortOrder)
            {
                case "name_desc":
                    ticketsQuery = ticketsQuery.OrderByDescending(t => t.Visitor.Name);
                    break;
                case "Date":
                    ticketsQuery = ticketsQuery.OrderBy(t => t.DateOfPurchase);
                    break;
                case "date_desc":
                    ticketsQuery = ticketsQuery.OrderByDescending(t => t.DateOfPurchase);
                    break;
                default:
                    ticketsQuery = ticketsQuery.OrderBy(t => t.Visitor.Name);
                    break;
            }

            // Pagination setup
            int pageSize = 5;
            var paginatedTickets = await PaginatedList<Ticket>.CreateAsync(ticketsQuery.AsNoTracking(), pageNumber ?? 1, pageSize);

            // Check if there are no tickets left after filtering and pagination
            if (!paginatedTickets.Any() && !String.IsNullOrEmpty(searchString))
            {
                return RedirectToAction("NoTickets");
            }

            // If there are no visitors created by the user
            if (visitorCount == 0)
            {
                // Redirect to an appropriate action if needed, or just render the view with an empty ticket list
                // For example: return RedirectToAction("Create", "Visitors"); to prompt the user to create visitors first
            }

            // Pass the visitor count to the view
            ViewData["VisitorCount"] = visitorCount;

            return View(paginatedTickets);
        }

        // NoTickets action
        public IActionResult NoTickets()
        {
            return View();
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
