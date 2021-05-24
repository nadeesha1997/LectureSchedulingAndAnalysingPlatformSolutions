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
    public class OnlineSessionsController : ControllerBase
    {
        private readonly UserDataContext _context;

        public OnlineSessionsController(UserDataContext context)
        {
            _context = context;
        }

        // GET: api/Approvals
        [HttpGet]
        public async Task<ActionResult<IEnumerable<OnlineSession>>> GetSession()
        {

            return await _context.OnlineSessions.ToListAsync();
        }

        // GET: api/Approvals/5
        [HttpGet("{id}")]
        public async Task<ActionResult<OnlineSession>> GetSession(int id)
        {
            var session = await _context.OnlineSessions
                .Include(i => i.Subject)
                .Where(i => i.Id == id)
                .FirstOrDefaultAsync();

            if (session == null)
            {
                return NotFound();
            }

            return session;
        }

        [HttpGet("{para}/{para2}")]
        public async Task<ActionResult<IEnumerable<OnlineSession>>> GetSessionByPara(string para, string para2)
        {
            if (para == "date")
            {
                var session = await _context.OnlineSessions
               .Include(i => i.Subject)
               .Where(i => i.StartTime == Convert.ToDateTime(para2))
               .ToListAsync();

                if (session == null)
                {
                    return NotFound();
                }

                return session;
            }
            else if (para == "dateonly")
            {
                var session = await _context.OnlineSessions
               .Include(i => i.Subject)
               .Where(i => i.StartTime.Date == Convert.ToDateTime(para2).Date)
               .ToListAsync();

                if (session == null)
                {
                    return NotFound();
                }

                return session;
            }
            else
            {
                List<OnlineSession> sessions = await _context.OnlineSessions
                .Include(i => i.Subject)
                .Where(i => i.StartTime == Convert.ToDateTime(para2))
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
        public async Task<ActionResult<OnlineSession>> GetSessionByTime(string para, string para2, int para3)
        {
            var session = await _context.OnlineSessions
           .Include(i => i.Subject)
           .Where(i => i.StartTime <= Convert.ToDateTime(para))
           .Where(i => i.EndTime >= Convert.ToDateTime(para2))
           .FirstOrDefaultAsync();

            if (session == null)
            {
                return NotFound();
            }

            return session;

        }
        [HttpGet("{para}/{para2}/{para3}/{para4}")]
        public async Task<ActionResult<IEnumerable<OnlineSession>>> GetSessionByPara(string para, string para2, string para3, int para4)
        {
            if (para == "date" && para3 == "hall")
            {
                var session = await _context.OnlineSessions
                .Include(i => i.Subject)
                .Where(i => i.StartTime.Date == Convert.ToDateTime(para2).Date)
                //.Where(i => i.EndDateTime >= Convert.ToDateTime(para2))
                .ToListAsync();

                if (session == null)
                {
                    return NotFound();
                }

                return session;
            }
            else
            {
                return NotFound();
            }
        }
        // PUT: api/Approvals/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSession(int id, OnlineSession onlineSession)
        {
            if (id != onlineSession.Id)
            {
                return BadRequest();
            }

            _context.Entry(onlineSession).State = EntityState.Modified;

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
        public async Task<ActionResult<Session>> PostSession(OnlineSession onlineSession)
        {
            _context.OnlineSessions.Add(onlineSession);
            await _context.SaveChangesAsync();
            return RedirectToAction("GetSession", new { id = onlineSession.Id });

        }

        // DELETE: api/Approvals/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<OnlineSession>> DeleteSession(int id)
        {
            var session = await _context.OnlineSessions.FindAsync(id);
            if (session == null)
            {
                return NotFound();
            }

            _context.OnlineSessions.Remove(session);
            await _context.SaveChangesAsync();

            return session;
        }

        private bool SessionExists(int id)
        {
            return _context.OnlineSessions.Any(e => e.Id == id);
        }
    }
}
