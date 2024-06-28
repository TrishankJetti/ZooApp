using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZooApp.data;
using ZooApp.Data;
using ZooApp.Models;

namespace ZooApp.Controllers
{
    [Authorize] // Ensures only authenticated users can access actions in this controller
    public class TicketsController : Controller
    {
        private readonly ZooAppContext _context;          
        private readonly UserManager<ApplicationUser> _userManager;

        //using dependecny injection, I have injected the UserManager and Context into the controller.
        public TicketsController(ZooAppContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        // GET: Tickets/Index
        public async Task<IActionResult> Index(string searchString, string sortOrder, int? pageNumber)
        {
            ViewData["CurrentFilter"] = searchString; //Search filter
            ViewData["NameSortParm"] = String.IsNullOrEmpty(sortOrder) ? "name_desc" : ""; //Name sorting
            ViewData["DateSortParm"] = sortOrder == "Date" ? "date_desc" : "Date"; //Date sorting
            ViewData["CurrentSort"] = sortOrder; // Current sort order that communicates to the pagination and tells it what sorts or search are applied to the site .

            var userId = _userManager.GetUserId(User); // Gets the current user's ID

            // Counts visitors created by the current users
            int visitorCount = await _context.Visitor
                                             .Where(v => v.CreatedByUserId == userId)
                                             .CountAsync();

            // Retrieves tickets for the current user
            var ticketsQuery = _context.Ticket
                                       .Include(t => t.Visitor)
                                       .Include(t => t.Event)
                                       .Where(t => t.Visitor.CreatedByUserId == userId); // This line here is important as it will only gather tickets that the current IdentityUser has created.

            //  search filter searches for the Visitor Name or email.
            if (!String.IsNullOrEmpty(searchString))
            {
                ticketsQuery = ticketsQuery.Where(t => t.Visitor.Name.Contains(searchString) || t.Visitor.Email.Contains(searchString));
            }

            //Sorting switch cases
            switch (sortOrder)
            {
                case "name_desc": // Sorts name descending
                    ticketsQuery = ticketsQuery.OrderByDescending(t => t.Visitor.Name);
                    break;
                case "Date": //Sorts date ascending
                    ticketsQuery = ticketsQuery.OrderBy(t => t.DateOfPurchase);
                    break;
                case "date_desc": //sorts date by descending order
                    ticketsQuery = ticketsQuery.OrderByDescending(t => t.DateOfPurchase);
                    break;
                default: // default sort that is activated once the website is launched.
                    ticketsQuery = ticketsQuery.OrderBy(t => t.Visitor.Name);
                    break;
            }

            // Pagination setup
            int pageSize = 5;
            var paginatedTickets = await PaginatedList<Ticket>.CreateAsync(ticketsQuery.AsNoTracking(), pageNumber ?? 1, pageSize);

            // If no tickets found after filtering and pagination, redirect to NoTickets action which then presents us with a view.
            if (!paginatedTickets.Any() && !String.IsNullOrEmpty(searchString))
            {
                return RedirectToAction("NoTickets");
            }

 

            ViewData["VisitorCount"] = visitorCount; // Pass visitor count to the view

            return View(paginatedTickets); // Render the view with paginated tickets
        }

        // NoTickets action
        public IActionResult NoTickets()
        {
            return View(); // Render the NoTickets view
        }


        // GET: Tickets/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userId = _userManager.GetUserId(User);


            //Gathers all tickets where createdby visitors is user id, in other words only tickets that the current user has created will show up.
            var ticket = await _context.Ticket
                .Include(t => t.Event)
                .Include(t => t.Visitor)
                .FirstOrDefaultAsync(t => t.TicketId == id && t.Visitor.CreatedByUserId == userId);

            if (ticket == null) // If ticket doesnt exist then the NotFOund view will be presented
            {
                return NotFound();
            }

            return View(ticket); // Return tickets.
        }




        // GET: Tickets/Create
        public IActionResult Create()
        {
            var userId = _userManager.GetUserId(User); // Get the current user's ID

            // Query visitors created by the current user
            var visitors = _context.Visitor
                                .Where(v => v.CreatedByUserId == userId)
                                .Select(v => new SelectListItem
                                {
                                    Text = v.Name,
                                    Value = v.VisitorId.ToString()
                                })
                                .ToList();

            ViewData["EventId"] = new SelectList(_context.Event, "EventId", "Name"); // Select Event Name
            ViewData["VisitorId"] = new SelectList(visitors, "Value", "Text"); // Select Visitor Name

            return View(); // Render the Create view
        }

        // POST: Tickets/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("TicketId,DateOfPurchase,EventId,VisitorId")] Ticket ticket)
        {
            var userId = _userManager.GetUserId(User); // Get the current user's ID
            if (!ModelState.IsValid)
            {
               

                // Check if the selected VisitorId belongs to the current user
                var visitor = await _context.Visitor.FindAsync(ticket.VisitorId);
                if (visitor == null || visitor.CreatedByUserId != userId)
                {
                    return Unauthorized(); // Return unauthorized if the visitor does not belong to the user
                }

                _context.Add(ticket); // Add the ticket to the context
                await _context.SaveChangesAsync(); // Save changes to the database

                return RedirectToAction(nameof(Index)); // Redirect to Index action
            }

            // If ModelState is not valid, re-render the view with necessary data
            ViewData["EventId"] = new SelectList(_context.Event, "EventId", "Name", ticket.EventId); // Select Event Name


            // Query visitors created by the current user
            var visitors = _context.Visitor
                                .Where(v => v.CreatedByUserId == userId)
                                .Select(v => new SelectListItem
                                {
                                    Text = v.Name,
                                    Value = v.VisitorId.ToString()
                                })
                                .ToList();

            ViewData["VisitorId"] = new SelectList(visitors, "Value", "Text", ticket.VisitorId); // Select Visitor Name

            return View(ticket); // Re-render the Create view with ticket model
        }

        // GET: Tickets/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound(); // Return NotFound if id is null
            }

            var userId = _userManager.GetUserId(User); // Get the current user's ID

            // Retrieve the ticket to edit and ensure it belongs to the current user
            var ticket = await _context.Ticket
                                        .Include(t => t.Event)
                                        .Include(t => t.Visitor)
                                        .FirstOrDefaultAsync(t => t.TicketId == id && t.Visitor.CreatedByUserId == userId);

            if (ticket == null)
            {
                return NotFound(); // Return NotFound if ticket is not found or does not belong to the user
            }

            ViewData["EventId"] = new SelectList(_context.Event, "EventId", "Name", ticket.EventId); // Select Event Name

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

            ViewData["VisitorId"] = new SelectList(visitors, "Value", "Text"); // Select Visitor Name

            return View(ticket); // Render the Edit view with the ticket model
        }

        // POST: Tickets/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("TicketId,DateOfPurchase,EventId,VisitorId")] Ticket ticket)
        {
            if (id != ticket.TicketId)
            {
                return NotFound(); // Return NotFound if id does not match ticket id
            }

            var userId = _userManager.GetUserId(User); // Get the current user's ID

            // Retrieve the existing ticket to edit and ensure it belongs to the current user
            var existingTicket = await _context.Ticket
                                                .Include(t => t.Visitor)
                                                .FirstOrDefaultAsync(t => t.TicketId == id && t.Visitor.CreatedByUserId == userId);

            if (existingTicket == null)
            {
                return NotFound(); // Return NotFound if ticket is not found or does not belong to the user
            }

            if (!ModelState.IsValid)
            {
                try
                {
                   

                    _context.Update(existingTicket); // Update the ticket in the context
                    await _context.SaveChangesAsync(); // Save changes to the database
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TicketExists(ticket.TicketId))
                    {
                        return NotFound(); // Return NotFound if ticket does not exist
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index)); // Redirect to Index action
            }

            // If ModelState is not valid, re-render the view with necessary data
            ViewData["EventId"] = new SelectList(_context.Event, "EventId", "Name", ticket.EventId); // Select Event Name

            var visitors = _context.Visitor
                                .Where(v => v.CreatedByUserId == userId)
                                .Select(v => new SelectListItem
                                {
                                    Text = v.Name,
                                    Value = v.VisitorId.ToString(),
                                    Selected = v.VisitorId == ticket.VisitorId // Pre-select the current ticket's visitor
                                })
                                .ToList();

            ViewData["VisitorId"] = new SelectList(visitors, "Value", "Text", ticket.VisitorId); // Select Visitor Name

            return View(ticket); // Re-render the Edit view with the ticket model
        }

        // GET: Tickets/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound(); // Return NotFound if id is null
            }

            // Retrieve the ticket to delete
            var ticket = await _context.Ticket
                                        .Include(t => t.Event)
                                        .Include(t => t.Visitor)
                                        .FirstOrDefaultAsync(m => m.TicketId == id);

            if (ticket == null)
            {
                return NotFound(); // Return NotFound if ticket is not found
            }

            return View(ticket); // Render the Delete view with the ticket model
        }

        // POST: Tickets/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var ticket = await _context.Ticket.FindAsync(id); // Find the ticket by id

            if (ticket != null)
            {
                _context.Ticket.Remove(ticket); // Remove the ticket from the context
                await _context.SaveChangesAsync(); // Save changes to the database
            }

            return RedirectToAction(nameof(Index)); // Redirect to Index action
        }

        private bool TicketExists(int id)
        {
            return _context.Ticket.Any(e => e.TicketId == id); // Check if ticket exists by id
        }
    }
}