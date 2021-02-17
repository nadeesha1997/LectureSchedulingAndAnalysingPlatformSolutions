using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using LectureSchedulingAndAnalysingPlatform.Data;
using LectureSchedulingAndAnalysingPlatform.Models;

namespace LectureSchedulingAndAnalysingPlatform.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReserversController : ControllerBase
    {
        private readonly UserDataContext _context;

        public ReserversController(UserDataContext context)
        {
            _context = context;
        }

        // GET: api/Reservers
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Reserver>>> GetReservers()
        {
            return await _context.Reservers.ToListAsync();
        }

        // GET: api/Reservers/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Reserver>> GetReserver(int id)
        {
            var reserver = await _context.Reservers
                .Include(i=>i.User)

                .Where(i => i.Id == id)
                .FirstOrDefaultAsync();

            if (reserver == null)
            {
                return NotFound();
            }

            return reserver;
        }

        // PUT: api/Reservers/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutReserver(int id, Reserver reserver)
        {
            if (id != reserver.Id)
            {
                return BadRequest();
            }

            _context.Entry(reserver).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ReserverExists(id))
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

        // POST: api/Reservers
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Reserver>> PostReserver(Reserver reserver)
        {
            _context.Reservers.Add(reserver);
            await _context.SaveChangesAsync();

            return RedirectToAction("GetReserver", new { id = reserver.Id });
        }

        // DELETE: api/Reservers/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Reserver>> DeleteReserver(int id)
        {
            var reserver = await _context.Reservers.FindAsync(id);
            if (reserver == null)
            {
                return NotFound();
            }

            _context.Reservers.Remove(reserver);
            await _context.SaveChangesAsync();

            return reserver;
        }

        private bool ReserverExists(int id)
        {
            return _context.Reservers.Any(e => e.Id == id);
        }
    }
}
