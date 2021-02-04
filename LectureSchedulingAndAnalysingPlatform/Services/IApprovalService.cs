using LectureSchedulingAndAnalysingPlatform.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LectureSchedulingAndAnalysingPlatform.Services
{
    interface IApprovalService
    {
        public List<Approval> GetAll();
        public Approval Get(int id);
        public void Add(Approval approval);
        public void Update(int id, Approval approval);
        public void Delete(int id);
    }
}
