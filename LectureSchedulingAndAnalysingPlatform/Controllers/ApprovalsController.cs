using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using LectureSchedulingAndAnalysingPlatform.Data;
using LectureSchedulingAndAnalysingPlatform.Models;
using LectureSchedulingAndAnalysingPlatform.Services;

namespace LectureSchedulingAndAnalysingPlatform.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApprovalsController : ControllerBase
    {
        private IApprovalService _approvalService;

        //public ApprovalsController(UserDataContext context)
        //{
        //    _context = context;
        //}
        public ApprovalsController(IApprovalService approvalService) => _approvalService = approvalService;

        // GET: api/Approvals
        [HttpGet]
        public List<Approval> Get()
        {
            return _approvalService.GetAll();
        }

        //public async Task<ActionResult<IEnumerable<Approval>>> GetA()
        //{

        //    return await _context.A.ToListAsync();
        //}

        // GET: api/Approvals/5
        [HttpGet("{id}")]
        public Approval Get(int id)
        {
            return _approvalService.GetOne(id);
        }
        //public async Task<ActionResult<Approval>> GetApproval(int id)
        //{
        //    var approval = await _context.A
        //        .Include(i => i.ApprovedBy)
        //        .Include(i => i.Permission)
        //        .Where(i => i.Id == id)
        //        .FirstOrDefaultAsync();

        //    if (approval == null)
        //    {
        //        return NotFound();
        //    }

        //    return approval;
        //}

        // PUT: api/Approvals/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Approval approval)
        {
            _approvalService.Update(id, approval);
        }
        //public async Task<IActionResult> PutApproval(int id, Approval approval)
        //{
        //    if (id != approval.Id)
        //    {
        //        return BadRequest();
        //    }

        //    _context.Entry(approval).State = EntityState.Modified;

        //    try
        //    {
        //        await _context.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!ApprovalExists(id))
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

        // POST: api/Approvals
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public void Post([FromBody] Approval approval)
        {
            _approvalService.Add(approval);

        }
        //public async Task<ActionResult<Approval>> PostApproval(Approval approval)
        //{
        //    _context.A.Add(approval);
        //    await _context.SaveChangesAsync();
        //    return RedirectToAction("GetApproval", new { id = approval.Id });

        //}

        // DELETE: api/Approvals/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _approvalService.Delete(id);
        }
        //public async Task<ActionResult<Approval>> DeleteApproval(int id)
        //{
        //    var approval = await _context.A.FindAsync(id);
        //    if (approval == null)
        //    {
        //        return NotFound();
        //    }

        //    _context.A.Remove(approval);
        //    await _context.SaveChangesAsync();

        //    return approval;
        //}

        //private bool ApprovalExists(int id)
        //{
        //    return _context.A.Any(e => e.Id == id);
        //}
    }
}
