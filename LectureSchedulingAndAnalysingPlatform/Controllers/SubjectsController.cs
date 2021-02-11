using LectureSchedulingAndAnalysingPlatform.Data;
using LectureSchedulingAndAnalysingPlatform.Models;
using LectureSchedulingAndAnalysingPlatform.Services;
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
    public class SubjectsController : ControllerBase
    {
        //private readonly UserDataContext _context;
        private ISubjectService _subjectService;

        public SubjectsController(ISubjectService subjectService)
        {
            //_context = context;
            _subjectService = subjectService;
        }

        //// GET: api/Approvals
        //[HttpGet]
        //public async Task<ActionResult<IEnumerable<Subject>>> GetSubject()
        //{

        //    return await _context.Subjects.ToListAsync();
        //}

        //// GET: api/Approvals/5
        //[HttpGet("{id}")]
        //public async Task<ActionResult<Subject>> GetSubject(int id)
        //{
        //    var approval = await _context.Subjects
        //        .Where(i => i.Id == id)
        //        .FirstOrDefaultAsync();

        //    if (approval == null)
        //    {
        //        return NotFound();
        //    }

        //    return approval;
        //}

        //// PUT: api/Approvals/5
        //// To protect from overposting attacks, enable the specific properties you want to bind to, for
        //// more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        //[HttpPut("{id}")]
        //public async Task<IActionResult> PutSubject(int id, Subject subject)
        //{
        //    if (id != subject.Id)
        //    {
        //        return BadRequest();
        //    }

        //    _context.Entry(subject).State = EntityState.Modified;

        //    try
        //    {
        //        await _context.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!SubjectExists(id))
        //        {
        //            return NotFound();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return NoContent();
        //}

        //// POST: api/Approvals
        //// To protect from overposting attacks, enable the specific properties you want to bind to, for
        //// more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        //[HttpPost]
        //public async Task<ActionResult<Subject>> PostSubject(Subject subject)
        //{
        //    _context.Subjects.Add(subject);
        //    await _context.SaveChangesAsync();
        //    return RedirectToAction("GetSubject", new { id = subject.Id });

        //}

        //// DELETE: api/Approvals/5
        //[HttpDelete("{id}")]
        //public async Task<ActionResult<Subject>> DeleteSubject(int id)
        //{
        //    var subject = await _context.Subjects.FindAsync(id);
        //    if (subject == null)
        //    {
        //        return NotFound();
        //    }

        //    _context.Subjects.Remove(subject);
        //    await _context.SaveChangesAsync();

        //    return subject;
        //}

        //private bool SubjectExists(int id)
        //{
        //    return _context.Subjects.Any(e => e.Id == id);
        //}
        [HttpGet]
        public List<Subject> Get()
        {
            return _subjectService.GetAll();
        }

        [HttpGet("{id}")]
        public Subject Get(int id)
        {
            return _subjectService.GetOne(id);
        }

        [HttpGet("{selector}/{value}")]
        public List<Subject> Get(string selector, string value)
        {
            return _subjectService.GetByOneValue(selector, value);
        }

        [HttpGet("{selector1}/{value1}/{selector2}/{value2}")]
        public List<Subject> Get(string selector1, string value1,string selector2,string value2)
        {
            return _subjectService.GetByTwoValues(selector1, value1, selector2, value2);
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Subject subject)
        {
            _subjectService.Update(id, subject);
        }

        [HttpPost]
        public void Post([FromBody] Subject subject)
        {
            _subjectService.Add(subject);

        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _subjectService.Delete(id);
        }
    }
}
