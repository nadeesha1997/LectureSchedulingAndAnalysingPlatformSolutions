using LectureSchedulingAndAnalysingPlatform.Data;
using LectureSchedulingAndAnalysingPlatform.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LectureSchedulingAndAnalysingPlatform.Services
{
    public class ApprovalService : IApprovalService
    {
        private readonly UserDataContext _context;

        public ApprovalService(UserDataContext context)
        {
            _context = context;
        }

        public void Add([FromBody]Approval approval)
        {
            _context.A.Add(approval);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            _context.A.Remove(GetOne(id));
            _context.SaveChanges();
        }

        ////public async task<actionresult<approval>> get(int id)
        ////{
        ////    var approval = await _context.a
        ////        .include(i => i.approvedby)
        ////        .include(i => i.permission)
        ////        .where(i => i.id == id)
        ////        .firstordefaultasync();

        ////    if (approval == null)
        ////    {
        ////        return notfound();
        ////    }

        ////    return approval;
        ////}

        public Approval GetOne(int id)
        {
            return _context.A
                .Include(i => i.Permission)
                .Include(i => i.ApprovedBy)
                .FirstOrDefault(i => i.Id == id);
        }

        /*[HttpGet()]
        [ProducesResponseType(StatusCodes.Status200OK, Type =typeof(Approval))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        */

        //public async Task<ActionResult<IEnumerable<Approval>>> GetAll()
        //{
        //    return await _context.A.ToListAsync();
        //}

        public List<Approval> GetAll()
        {
            return _context.A.Include(i=>i.ApprovedBy).Include(i=>i.Permission).ToList();
        }

        public void Update(int id, Approval approval)
        {
            _context.A.Update(approval);
            _context.SaveChanges();
        }
    }
}
