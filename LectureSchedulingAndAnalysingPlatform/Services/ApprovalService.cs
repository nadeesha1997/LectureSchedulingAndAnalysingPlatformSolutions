using LectureSchedulingAndAnalysingPlatform.Data;
using LectureSchedulingAndAnalysingPlatform.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LectureSchedulingAndAnalysingPlatform.Services
{
    public class ApprovalService : IApprovalService
    {
        private readonly UserDataContext _context;

        public ApprovalService(UserDataContext context)
        {
            _context = context;
        }
        public void Add(Approval approval)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Approval Get(int id)
        {
            throw new NotImplementedException();
        }

        /*[HttpGet()]
        [ProducesResponseType(StatusCodes.Status200OK, Type =typeof(Approval))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        */
        
        public List<Approval> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(int id, Approval approval)
        {
            throw new NotImplementedException();
        }
    }
}
