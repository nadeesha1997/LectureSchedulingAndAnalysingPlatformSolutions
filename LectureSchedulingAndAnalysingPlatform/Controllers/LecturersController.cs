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
    public class LecturersController : ControllerBase
    {
        private readonly UserDataContext _context;

        public LecturersController(UserDataContext context)
        {
            _context = context;
        }

        // GET: api/Buildings
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Lecturer>>> GetLecturers()
        {
            return await _context.Lecturers.ToListAsync();
        }

        // GET: api/Buildings/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Lecturer>> GetLecturer(int id)
        {
            var lecturer = await _context.Lecturers
                .Where(i => i.Id == id)
                .FirstOrDefaultAsync();

            if (lecturer == null)
            {
                return NotFound();
            }

            return lecturer;
        }

        // PUT: api/Buildings/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutLecturer(int id, Lecturer lecturer)
        {
            if (id != lecturer.Id)
            {
                return BadRequest();
            }

            _context.Entry(lecturer).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LecturerExists(id))
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
        public async Task<ActionResult<Lecturer>> PostLecturer(Lecturer lecturer)
        {
            _context.Lecturers.Add(lecturer);
            await _context.SaveChangesAsync();

            return RedirectToAction("GetLecturer", new { id = lecturer.Id });
        }

        // DELETE: api/Buildings/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Lecturer>> DeleteLecturer(int id)
        {
            var lecturer = await _context.Lecturers.FindAsync(id);
            if (lecturer == null)
            {
                return NotFound();
            }

            _context.Lecturers.Remove(lecturer);
            await _context.SaveChangesAsync();

            return lecturer;
        }

        private bool LecturerExists(int id)
        {
            return _context.Lecturers.Any(e => e.Id == id);
        }
    }
}

