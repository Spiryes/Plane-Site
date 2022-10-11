﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PlaneTest1.Data;
using PlaneTest1.Models;

namespace PlaneTest1.Controllers
{
    public class FlightsController : Controller
    {
        private readonly FlightsTicketsDbContext _context;

        public FlightsController(FlightsTicketsDbContext context)
        {
            _context = context;
        }

        // GET: Flights
        [Authorize(Roles = "Administrator")]// da ima rolq che da ima perm da pipa tam
        public async Task<IActionResult> Index()
        {
            return View(await _context.Flights.ToListAsync());
        }

        // GET: Flights/Details/5
        [Authorize(Roles = "Administrator")]// da ima rolq che da ima perm da pipa tam
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var flights = await _context.Flights
                .FirstOrDefaultAsync(m => m.PlaneNumber == id);
            if (flights == null)
            {
                return NotFound();
            }

            return View(flights);
        }

        // GET: Flights/Create
        [Authorize (Roles = "Administrator")]// da ima rolq che da ima perm da pipa tam
        public IActionResult Create()
        {
            return View();
        }

        // POST: Flights/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PlaneNumber,Arrival,Departure,PilotName,From,To,BuisnesSeats,NormalSeats")] Flights flights)
        {
            if (ModelState.IsValid)
            {
                _context.Add(flights);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(flights);
        }

        // GET: Flights/Edit/5
        [Authorize(Roles = "Administrator")]// da ima rolq che da ima perm da pipa tam
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var flights = await _context.Flights.FindAsync(id);
            if (flights == null)
            {
                return NotFound();
            }
            return View(flights);
        }

        // POST: Flights/Edit/5
        [Authorize(Roles = "Administrator")]// da ima rolq che da ima perm da pipa tam
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("PlaneNumber,Arrival,Departure,PilotName,From,To,BuisnesSeats,NormalSeats")] Flights flights)
        {
            if (id != flights.PlaneNumber)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(flights);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FlightsExists(flights.PlaneNumber))
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
            return View(flights);
        }

        // GET: Flights/Delete/5
        [Authorize(Roles = "Administrator")]// da ima rolq che da ima perm da pipa tam
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var flights = await _context.Flights
                .FirstOrDefaultAsync(m => m.PlaneNumber == id);
            if (flights == null)
            {
                return NotFound();
            }

            return View(flights);
        }

        // POST: Flights/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var flights = await _context.Flights.FindAsync(id);
            _context.Flights.Remove(flights);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FlightsExists(int id)
        {
            return _context.Flights.Any(e => e.PlaneNumber == id);
        }
        public async Task<IActionResult> IndexRest()
        {
            return View(await _context.Flights.ToListAsync());
        }
    }
}
