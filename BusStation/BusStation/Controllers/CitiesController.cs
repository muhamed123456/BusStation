﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BusStation.Models;

namespace BusStation.Controllers
{
    public class CitiesController : Controller
    {
        private readonly BusStationContext _context;

        public CitiesController(BusStationContext context)
        {
            _context = context;
        }

        // GET: Cities
        public async Task<IActionResult> Index(string CitiesDestination, string searchString)
        {
            IQueryable<string> destinationQuery = from c in _context.Cities
                                                  orderby c.DestinationCity
                                                  select c.DestinationCity;

            var cities = from c in _context.Cities
                         select c;

            if (!String.IsNullOrEmpty(searchString))
            {
                cities = cities.Where(s => s.DepartureCity.Contains(searchString));
            }

            if (!String.IsNullOrEmpty(CitiesDestination))
            {
                cities = cities.Where(x => x.DestinationCity == CitiesDestination);
            }

            var CitiesDestinationVM = new CitiesDestinationViewModel();
            CitiesDestinationVM.destination = new SelectList(await destinationQuery.Distinct().ToListAsync());
            CitiesDestinationVM.cities = await cities.ToListAsync();


            return View(CitiesDestinationVM);
        }

        // GET: Cities/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cities = await _context.Cities
                .SingleOrDefaultAsync(m => m.ID == id);
            if (cities == null)
            {
                return NotFound();
            }

            return View(cities);
        }

        // GET: Cities/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Cities/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,DepartureCity,DestinationCity,DepartureTime,ArrivalTime,BusCompany,Price")] Cities cities)
        {
            if (ModelState.IsValid)
            {
                _context.Add(cities);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(cities);
        }

        // GET: Cities/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cities = await _context.Cities.SingleOrDefaultAsync(m => m.ID == id);
            if (cities == null)
            {
                return NotFound();
            }
            return View(cities);
        }

        // POST: Cities/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,DepartureCity,DestinationCity,DepartureTime,ArrivalTime,BusCompany,Price")] Cities cities)
        {
            if (id != cities.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(cities);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CitiesExists(cities.ID))
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
            return View(cities);
        }

        // GET: Cities/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cities = await _context.Cities
                .SingleOrDefaultAsync(m => m.ID == id);
            if (cities == null)
            {
                return NotFound();
            }

            return View(cities);
        }

        // POST: Cities/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var cities = await _context.Cities.SingleOrDefaultAsync(m => m.ID == id);
            _context.Cities.Remove(cities);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CitiesExists(int id)
        {
            return _context.Cities.Any(e => e.ID == id);
        }
    }
}
