﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using LectureSchedulingAndAnalysingPlatform.Data;
using LectureSchedulingAndAnalysingPlatform.Models;
using Microsoft.AspNetCore.Authorization;

namespace LectureSchedulingAndAnalysingPlatform.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class SubjectUserController : ControllerBase
    {
        private readonly UserDataContext _context;

        public SubjectUserController(UserDataContext context)
        {
            _context = context;
        }

        // GET: api/Buildings
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SubjectUser>>> GetSubjectUser()
        {
            return await _context.SubjectUsers
                .Include(i=>i.User)
                .Include(i=>i.Subject)
                .ToListAsync();
        }

        // GET: api/Buildings/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SubjectUser>> GetSubjectUser(int id)
        {
            var subjectUser = await _context.SubjectUsers
                .Include(i => i.User)
                .Include(i => i.Subject)
                .Where(i => i.Id == id)
                .FirstOrDefaultAsync();

            if (subjectUser == null)
            {
                return NotFound();
            }

            return subjectUser;
        }

        [HttpGet("{para1}/{para2}")]
        public async Task<ActionResult<IEnumerable<SubjectUser>>> GetSubjectByUser(string para1,string para2)
        {
            if (para1 == "user")
            {
                var subjectUser = await _context.SubjectUsers
                .Include(i => i.User)
                .Include(i => i.Subject)
                .Where(i => i.UserId == para2)
                .ToListAsync();

                if (subjectUser == null)
                {
                    return NotFound();
                }

                return subjectUser;
            }
            else
            {
                return NotFound();
            }
        }
        // PUT: api/Buildings/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        //[httpput("{id}")]
        //public async task<iactionresult> putbuilding(int id, building building)
        //{
        //    if (id != building.id)
        //    {
        //        return badrequest();
        //    }

        //    _context.Entry(building).State = EntityState.Modified;

        //    try
        //    {
        //        await _context.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!BuildingExists(id))
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

        // POST: api/Buildings
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<SubjectUser>> PostSubjectUser(SubjectUser subjectUser)
        {
            _context.SubjectUsers.Add(subjectUser);
            await _context.SaveChangesAsync();

            return RedirectToAction("GetSubjectUser", new { id = subjectUser.Id });
        }

        // DELETE: api/Buildings/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<SubjectUser>> DeleteSubjectUser(int id)
        {
            var subjectUser = await _context.SubjectUsers.FindAsync(id);
            if (subjectUser == null)
            {
                return NotFound();
            }

            _context.SubjectUsers.Remove(subjectUser);
            await _context.SaveChangesAsync();

            return subjectUser;
        }

        [HttpDelete("{id}/{subject}")]
        public async Task<ActionResult<SubjectUser>> DeleteSubjectUserBySubject(string id,int subject)
        {
            var subjectUser = await _context.SubjectUsers
                .Where(i => i.UserId == id)
                .Where(i => i.SubjectId == subject)
                .FirstOrDefaultAsync();
            if (subjectUser == null)
            {
                return NotFound();
            }

            _context.SubjectUsers.Remove(subjectUser);
            await _context.SaveChangesAsync();

            return subjectUser;
        }

        private bool BuildingExists(int id)
        {
            return _context.Buildings.Any(e => e.Id == id);
        }
    }
}
