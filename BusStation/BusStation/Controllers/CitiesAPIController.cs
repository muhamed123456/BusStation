using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BusStation.Models;

namespace BusStation.Controllers
{
    [Produces("application/json")]
    [Route("api/CitiesAPI")]
    public class CitiesAPIController : Controller
    {
        private readonly BusStationContext _context;

        public CitiesAPIController(BusStationContext context)
        {
            _context = context;
        }

        // GET: api/CitiesAPI
        [HttpGet]
        public IEnumerable<Cities> GetCities()
        {
            return _context.Cities;
        }

        // GET: api/CitiesAPI/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetCities([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var cities = await _context.Cities.SingleOrDefaultAsync(m => m.ID == id);

            if (cities == null)
            {
                return NotFound();
            }

            return Ok(cities);
        }

        // PUT: api/CitiesAPI/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCities([FromRoute] int id, [FromBody] Cities cities)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != cities.ID)
            {
                return BadRequest();
            }

            _context.Entry(cities).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CitiesExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/CitiesAPI
        [HttpPost]
        public async Task<IActionResult> PostCities([FromBody] Cities cities)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Cities.Add(cities);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCities", new { id = cities.ID }, cities);
        }

        // DELETE: api/CitiesAPI/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCities([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var cities = await _context.Cities.SingleOrDefaultAsync(m => m.ID == id);
            if (cities == null)
            {
                return NotFound();
            }

            _context.Cities.Remove(cities);
            await _context.SaveChangesAsync();

            return Ok(cities);
        }

        private bool CitiesExists(int id)
        {
            return _context.Cities.Any(e => e.ID == id);
        }
    }
}