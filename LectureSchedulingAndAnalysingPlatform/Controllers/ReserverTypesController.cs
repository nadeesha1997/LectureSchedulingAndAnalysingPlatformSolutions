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
    public class ReserverTypesController : ControllerBase
    {
        private readonly UserDataContext _context;

        public ReserverTypesController(UserDataContext context)
        {
            _context = context;
        }

        // GET: api/ReserverTypes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ReserverType>>> GetReserverTypes()
        {
            return await _context.ReserverTypes.ToListAsync();
        }

        // GET: api/ReserverTypes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ReserverType>> GetReserverType(int id)
        {
            var reserverType = await _context.ReserverTypes.FindAsync(id);

            if (reserverType == null)
            {
                return NotFound();
            }

            return reserverType;
        }

        // PUT: api/ReserverTypes/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutReserverType(int id, ReserverType reserverType)
        {
            if (id != reserverType.Id)
            {
                return BadRequest();
            }

            _context.Entry(reserverType).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ReserverTypeExists(id))
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

        // POST: api/ReserverTypes
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<ReserverType>> PostReserverType(ReserverType reserverType)
        {
            _context.ReserverTypes.Add(reserverType);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetReserverType", new { id = reserverType.Id }, reserverType);
        }

        // DELETE: api/ReserverTypes/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<ReserverType>> DeleteReserverType(int id)
        {
            var reserverType = await _context.ReserverTypes.FindAsync(id);
            if (reserverType == null)
            {
                return NotFound();
            }

            _context.ReserverTypes.Remove(reserverType);
            await _context.SaveChangesAsync();

            return reserverType;
        }

        private bool ReserverTypeExists(int id)
        {
            return _context.ReserverTypes.Any(e => e.Id == id);
        }
    }
}
