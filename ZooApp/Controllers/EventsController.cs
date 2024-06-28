using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using ZooApp.data;
using ZooApp.Models;

namespace ZooApp.Controllers
{
    public class EventsController : Controller
    {
        
        private readonly ZooAppContext _context;
     
        private readonly IWebHostEnvironment _hostEnvironment;

        // Constructor to initialize the context and host environment used for the images.
        public EventsController(ZooAppContext context, IWebHostEnvironment hostEnvironment)
        {
            _context = context;
            _hostEnvironment = hostEnvironment;
        }

        // GET: Events
        // Method to display a list of events, optionally filtered by search string and price range
        public async Task<IActionResult> Index(string searchString, decimal? minPrice, decimal? maxPrice)
        {
            // Set up view data for filters to persist them on the view
            ViewData["EventNameFilter"] = searchString;
            ViewData["MinPrice"] = minPrice;
            ViewData["MaxPrice"] = maxPrice;

            // Start querying events from the database
            var events = _context.Event.AsQueryable();

            // Apply search filter if provided
            if (!String.IsNullOrEmpty(searchString))
            {
                events = events.Where(e => e.Name.Contains(searchString));
            }

            // Apply minimum price filter if provided
            if (minPrice != null)
            {
                events = events.Where(e => e.TicketPrice >= minPrice);
            }

            // Apply maximum price filter if provided
            if (maxPrice != null)
            {
                events = events.Where(e => e.TicketPrice <= maxPrice);
            }

            // Check if any events match the criteria
            if (events.Any())
            {
                // Return the view with the filtered events
                return View(events);
            }
            else
            {
                // Show a view indicating no events found
                return View("NoEvents");
            }

            // Return the view with the list of events asynchronously
            return View(await events.ToListAsync());
        }

        // GET: Events/Details/5
        // Method to display the details of a specific event by its ID
        public async Task<IActionResult> Details(int? id)
        {
            // Check if the ID parameter is null
            if (id == null)
            {
                return NotFound();
            }

            // Retrieve the event from the database using the ID
            var @event = await _context.Event
                .FirstOrDefaultAsync(m => m.EventId == id);

            // Check if the event is null (not found)
            if (@event == null)
            {
                return NotFound();
            }

            // Return the view with the event details
            return View(@event);
        }

        // GET: Events/Create
        // Method to display the event creation form
        [Authorize(Roles = "Admin, Employee")]
        public IActionResult Create()
        {
            return View();
        }

        // POST: Events/Create
        // Method to handle the event creation form submission
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin, Employee")]
        public async Task<IActionResult> Create([Bind("EventId,Date,Name,Description,TicketPrice,ImageFile")] Event @event)
        {
            // Check if the model state is valid
            if (!ModelState.IsValid)
            {
                // Handles file uplaod if an iamge is uploaded
                if (@event.ImageFile != null)
                {
                    // Generate a unique file name by appending the current timestamp to the name of the image.
                    string fileName = Path.GetFileNameWithoutExtension(@event.ImageFile.FileName);
                    string extension = Path.GetExtension(@event.ImageFile.FileName);
                    @event.ImageFileName = fileName = fileName + DateTime.Now.ToString("yymmssfff") + extension;
                    string path = Path.Combine(_hostEnvironment.WebRootPath, "images", fileName);

                    // Save the file to the specified path
                    using (var fileStream = new FileStream(path, FileMode.Create))
                    {
                        await @event.ImageFile.CopyToAsync(fileStream);
                    }
                }

                // Adds the event to the context and save changes
                _context.Add(@event);
                await _context.SaveChangesAsync();
                // Redirect to the Index action
                return RedirectToAction(nameof(Index));
            }
            return View(@event);
        }

        // GET: Events/Edit/5
        // Method to display the event edit form for a specific event by its ID
        [Authorize(Roles = "Admin, Employee")]
        public async Task<IActionResult> Edit(int? id)
        {
            // Check if the ID parameter is null
            if (id == null)
            {
                return NotFound();
            }

            // Retrieve the event from the database using the ID
            var @event = await _context.Event.FindAsync(id);

            // Check if the event is null (not found)
            if (@event == null)
            {
                return NotFound();
            }
            // Return the view with the event model
            return View(@event);
        }

        // POST: Events/Edit/5
        // POST: Events/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin, Employee")]
        public async Task<IActionResult> Edit(int id, [Bind("EventId,Name,Date,Description,TicketPrice,ImageFile,ImageFileName")] Event updatedEvent)
        {
            // Check if the ID parameter matches the event ID
            if (id != updatedEvent.EventId)
            {
                return NotFound();
            }

            // Check if the model state is valid
            if (!ModelState.IsValid)
            {
                try
                {
                    // Retrieve the existing event from the database
                    var existingEvent = await _context.Event.FindAsync(id);

                    if (existingEvent == null)
                    {
                        return NotFound();
                    }

                    // Update the specific properties of the existing event
                    existingEvent.Name = updatedEvent.Name;
                    existingEvent.Date = updatedEvent.Date;
                    existingEvent.Description = updatedEvent.Description;
                    existingEvent.TicketPrice = updatedEvent.TicketPrice;

                    // Handle file upload if a new image file is provided
                    if (updatedEvent.ImageFile != null && updatedEvent.ImageFile.Length > 0)
                    {
                        

                        // Generate a unique file name for the new image
                        string fileName = Path.GetFileNameWithoutExtension(updatedEvent.ImageFile.FileName);
                        string extension = Path.GetExtension(updatedEvent.ImageFile.FileName);
                        existingEvent.ImageFileName = fileName + DateTime.Now.ToString("yymmssfff") + extension;
                        string path = Path.Combine(_hostEnvironment.WebRootPath, "images", existingEvent.ImageFileName);

                        // Save the file to the specified path
                        using (var fileStream = new FileStream(path, FileMode.Create))
                        {
                            await updatedEvent.ImageFile.CopyToAsync(fileStream);
                        }
                    }
                    else if (string.IsNullOrEmpty(updatedEvent.ImageFileName))
                    {
                        // If no new ImageFile is provided and ImageFileName is null or empty,
                        // set it to the existing ImageFileName to maintain the current image
                        existingEvent.ImageFileName = existingEvent.ImageFileName;
                    }

                    // Update the event in the context and save changes
                    _context.Update(existingEvent);
                    await _context.SaveChangesAsync();

                    // Redirect to the Index action if the update is successful
                    return RedirectToAction(nameof(Index));
                }
                catch (DbUpdateConcurrencyException)
                {
                    // Check if the event exists
                    if (!EventExists(updatedEvent.EventId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        // Rethrow the exception if it is not related to concurrency
                        throw;
                    }
                }
            }

            // If ModelState is not valid, reload necessary data and return to the view with errors
            return View(updatedEvent);
        }

      






        // GET: Events/Delete/5
        // Method to display the event deletion confirmation page for a specific event by its ID
        [Authorize(Roles = "Admin, Employee")]
        public async Task<IActionResult> Delete(int? id)
        {
            // Check if the ID parameter is null
            if (id == null)
            {
                return NotFound();
            }

            // Retrieve the event from the database using the ID
            var @event = await _context.Event
                .FirstOrDefaultAsync(m => m.EventId == id);

            // Check if the event is null (not found)
            if (@event == null)
            {
                return NotFound();
            }

            // Return the view with the event model
            return View(@event);
        }

        // POST: Events/Delete/5
        // Method to handle the event deletion confirmation form submission
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin, Employee")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            // Retrieve the event from the database using the ID
            var @event = await _context.Event.FindAsync(id);

            // Check if the event is not null before attempting to delete
            if (@event != null)
            {
                _context.Event.Remove(@event);
            }

            // Save changes to the context
            await _context.SaveChangesAsync();

            // Redirect to the Index action
            return RedirectToAction(nameof(Index));
        }

        // Helper method to check if an event exists by its ID
        private bool EventExists(int id)
        {
            return _context.Event.Any(e => e.EventId == id);
        }
    }
}
