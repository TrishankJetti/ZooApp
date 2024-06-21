﻿using System;
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
        public async Task<IActionResult> Quiz()
        {


            return View();
        }
        private readonly ZooAppContext _context;
        private readonly IWebHostEnvironment _hostEnvironment;

        public EventsController(ZooAppContext context, IWebHostEnvironment hostEnvironment)
        {
            _context = context;
            _hostEnvironment = hostEnvironment;
        }

        // GET: Events
        public async Task<IActionResult> Index(string searchString, decimal? minPrice, decimal? maxPrice)
        {
            ViewData["EventNameFilter"] = searchString;
            ViewData["MinPrice"] = minPrice;
            ViewData["MaxPrice"] = maxPrice;

            var events = _context.Event.AsQueryable();

            if (!String.IsNullOrEmpty(searchString))
            {
                events = events.Where(e => e.Name.Contains(searchString));
            }

            if (minPrice != null)
            {
                events = events.Where(e => e.TicketPrice >= minPrice);
            }

            if (maxPrice != null)
            {
                events = events.Where(e => e.TicketPrice <= maxPrice);
            }

            //This code makes sure that if the event exists, that the suer enters in they will show the results, else if there isnt any results the page called NoResults will show up.
            if (events.Any())
            {
                return View(events);
            }
            else
            {
                return View("NoEvents");
            }

            return View(await events.ToListAsync());
        }



        // GET: Events/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var @event = await _context.Event
                .FirstOrDefaultAsync(m => m.EventId == id);
            if (@event == null)
            {
                return NotFound();
            }

            return View(@event);
        }

        // GET: Events/Create
        [Authorize(Roles = "Admin , Employee")]
        public IActionResult Create()
        {
            return View();
        }
        // POST: Events/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin , Employee")]
        public async Task<IActionResult> Create([Bind("EventId,Date,Name,Description,TicketPrice,ImageFile")] Event @event)
        {
            if (!ModelState.IsValid)
            {
                // Handle file upload
                if (@event.ImageFile != null)
                {
                    string fileName = Path.GetFileNameWithoutExtension(@event.ImageFile.FileName);
                    string extension = Path.GetExtension(@event.ImageFile.FileName);
                    @event.ImageFileName = fileName = fileName + DateTime.Now.ToString("yymmssfff") + extension;
                    string path = Path.Combine(_hostEnvironment.WebRootPath, "images", fileName);
                    using (var fileStream = new FileStream(path, FileMode.Create))
                    {
                        await @event.ImageFile.CopyToAsync(fileStream);
                    }
                }

                _context.Add(@event);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(@event);
        }
        // GET: Events/Edit/5
        [Authorize(Roles = "Admin , Employee")]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var @event = await _context.Event.FindAsync(id);
            if (@event == null)
            {
                return NotFound();
            }
            return View(@event);
        }

        // POST: Events/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin , Employee")]
        public async Task<IActionResult> Edit(int id, [Bind("EventId,Name,Date,Description,TicketPrice,ImageFileName,ImageFile")] Event @event)
        {
            if (id != @event.EventId)
            {
                return NotFound();
            }

            if (!ModelState.IsValid)
            {
                try
                {
                    // Handle file upload
                    if (@event.ImageFile != null)
                    {
                        string fileName = Path.GetFileNameWithoutExtension(@event.ImageFile.FileName);
                        string extension = Path.GetExtension(@event.ImageFile.FileName);
                        @event.ImageFileName = fileName = fileName + DateTime.Now.ToString("yymmssfff") + extension;
                        string path = Path.Combine(_hostEnvironment.WebRootPath, "images", fileName);
                        using (var fileStream = new FileStream(path, FileMode.Create))
                        {
                            await @event.ImageFile.CopyToAsync(fileStream);
                        }
                    }

                    _context.Update(@event);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EventExists(@event.EventId))
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
            return View(@event);
        }


        // GET: Events/Delete/5
        [Authorize(Roles = "Admin , Employee")]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var @event = await _context.Event
                .FirstOrDefaultAsync(m => m.EventId == id);
            if (@event == null)
            {
                return NotFound();
            }

            return View(@event);
        }

        // POST: Events/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin , Employee")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var @event = await _context.Event.FindAsync(id);
            if (@event != null)
            {
                _context.Event.Remove(@event);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EventExists(int id)
        {
            return _context.Event.Any(e => e.EventId == id);
        }
    }
}
