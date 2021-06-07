using LectureSchedulingAndAnalysingPlatform.Data;
using LectureSchedulingAndAnalysingPlatform.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LectureSchedulingAndAnalysingPlatform.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HodController : ControllerBase
    {
        private readonly UserDataContext _context;

        public HodController(UserDataContext context)
        {
            _context = context;
        }

        // GET: api/Buildings
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Hod>>> GetHods()
        {
            return await _context.Hods.ToListAsync();
        }

        // GET: api/Buildings/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Hod>> GetHod(int id)
        {
            var building = await _context.Hods
                //.Include(i => i.User)
                //.Include(i=>i.Department)
                .Where(i => i.Id == id)
                .FirstOrDefaultAsync();

            if (building == null)
            {
                return NotFound();
            }

            return building;
        }

        // PUT: api/Buildings/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutHod(int id, Hod hod)
        {
            if (id != hod.Id)
            {
                return BadRequest();
            }

            _context.Entry(hod).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BuildingExists(id))
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

        // POST: api/Buildings
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Hod>> PostHod(Hod hod)
        {
            _context.Hods.Add(hod);
            await _context.SaveChangesAsync();

            return RedirectToAction("GetHod", new { id = hod.Id });
        }

        // DELETE: api/Buildings/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Hod>> DeleteHod(int id)
        {
            var building = await _context.Hods.FindAsync(id);
            if (building == null)
            {
                return NotFound();
            }

            _context.Hods.Remove(building);
            await _context.SaveChangesAsync();

            return building;
        }

        private bool BuildingExists(int id)
        {
            return _context.Hods.Any(e => e.Id == id);
        }
    }
}
