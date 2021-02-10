using LectureSchedulingAndAnalysingPlatform.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LectureSchedulingAndAnalysingPlatform.Services
{
    public interface IApprovalService
    {
        public List<Approval> GetAll();
        public Approval GetOne(int id);
        public void Add(Approval approval);
        public void Update(int id, Approval approval);
        public void Delete(int id);
    }
}
