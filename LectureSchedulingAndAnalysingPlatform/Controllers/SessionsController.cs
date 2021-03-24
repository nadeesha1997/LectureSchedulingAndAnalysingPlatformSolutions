﻿using LectureSchedulingAndAnalysingPlatform.Data;
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
    public class SessionsController : ControllerBase
    {
        private readonly UserDataContext _context;

        public SessionsController(UserDataContext context)
        {
            _context = context;
        }

        // GET: api/Approvals
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Session>>> GetSession()
        {

            return await _context.Sessions.ToListAsync();
        }

        // GET: api/Approvals/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Session>> GetSession(int id)
        {
            var session = await _context.Sessions
                .Include(i=>i.Subject)
                .Include(i=>i.Hall)
                .Where(i => i.Id == id)
                .FirstOrDefaultAsync();

            if (session == null)
            {
                return NotFound();
            }

            return session;
        }

        [HttpGet("{para}/{para2}")]
        public async Task<ActionResult<IEnumerable<Session>>> GetSessionByPara(string para, string para2)
        {
            if (para == "date")
            {
                var session = await _context.Sessions
               .Include(i => i.Subject)
               .Include(i => i.Hall)
               .Where(i => i.StartDateTime == Convert.ToDateTime(para2))
               .ToListAsync();

                if (session == null)
                {
                    return NotFound();
                }

                return session;
            }
            else if (para == "dateonly")
            {
                var session = await _context.Sessions
               .Include(i => i.Subject)
               .Include(i => i.Hall)
               .Where(i => i.StartDateTime.Date == Convert.ToDateTime(para2).Date)
               .ToListAsync();

                if (session == null)
                {
                    return NotFound();
                }

                return session;
            }
            else
            {
                List<Session> sessions = await _context.Sessions
                .Include(i => i.Subject)
                .Include(i => i.Hall)
                .Where(i => i.StartDateTime == Convert.ToDateTime(para2))
                .Where(i => i.UserId == para)
                .ToListAsync();

                //if (sessions == null)
                //{
                //    return NotFound();
                //}

                return sessions;
            }
        }
        [HttpGet("{para}/{para2}/{para3}")]
        public async Task<ActionResult<Session>> GetSessionByTime(string para, string para2,int para3)
        {
            var session = await _context.Sessions
           .Include(i => i.Subject)
           .Include(i => i.Hall)
           .Where(i => i.StartDateTime <= Convert.ToDateTime(para))
           .Where(i=>i.EndDateTime>=Convert.ToDateTime(para2))
           .Where(i => i.HallId == para3)
           .FirstOrDefaultAsync();

                if (session == null)
                {
                    return NotFound();
                }

                return session;

        }
        // PUT: api/Approvals/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSession(int id, Session session)
        {
            if (id != session.Id)
            {
                return BadRequest();
            }

            _context.Entry(session).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SessionExists(id))
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

        // POST: api/Approvals
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Session>> PostSession(Session session)
        {
            _context.Sessions.Add(session);
            await _context.SaveChangesAsync();
            return RedirectToAction("GetSession", new { id = session.Id });

        }

        // DELETE: api/Approvals/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Session>> DeleteSession(int id)
        {
            var session = await _context.Sessions.FindAsync(id);
            if (session == null)
            {
                return NotFound();
            }

            _context.Sessions.Remove(session);
            await _context.SaveChangesAsync();

            return session;
        }

        private bool SessionExists(int id)
        {
            return _context.Sessions.Any(e => e.Id == id);
        }
    }
}
