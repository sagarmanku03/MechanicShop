using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MechanicShop.Data;
using MechanicShop.Models;

namespace MechanicShop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class managementsController : ControllerBase
    {
        private readonly MechanicShopContext _context;

        public managementsController(MechanicShopContext context)
        {
            _context = context;
        }

        // GET: api/managements
        [HttpGet]
        public async Task<ActionResult<IEnumerable<management>>> Getmanagement()
        {
            return await _context.management.ToListAsync();
        }

        // GET: api/managements/5
        [HttpGet("{id}")]
        public async Task<ActionResult<management>> Getmanagement(int id)
        {
            var management = await _context.management.FindAsync(id);

            if (management == null)
            {
                return NotFound();
            }

            return management;
        }

        // PUT: api/managements/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> Putmanagement(int id, management management)
        {
            if (id != management.Id)
            {
                return BadRequest();
            }

            _context.Entry(management).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!managementExists(id))
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

        // POST: api/managements
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<management>> Postmanagement(management management)
        {
            _context.management.Add(management);
            await _context.SaveChangesAsync();

            return CreatedAtAction("Getmanagement", new { id = management.Id }, management);
        }

        // DELETE: api/managements/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<management>> Deletemanagement(int id)
        {
            var management = await _context.management.FindAsync(id);
            if (management == null)
            {
                return NotFound();
            }

            _context.management.Remove(management);
            await _context.SaveChangesAsync();

            return management;
        }

        private bool managementExists(int id)
        {
            return _context.management.Any(e => e.Id == id);
        }
    }
}
