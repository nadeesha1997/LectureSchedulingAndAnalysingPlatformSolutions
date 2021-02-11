using LectureSchedulingAndAnalysingPlatform.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LectureSchedulingAndAnalysingPlatform.Services
{
    public interface ISubjectService
    {
        public List<Subject> GetAll();
        public List<Subject> GetByOneValue(string selector, string value);
        public List<Subject> GetByTwoValues(string selector1, string val1, string selector2, string val2);
        public Subject GetOne(int id);
        public void Add(Subject subject);
        public void Update(int id, Subject subject);
        public void Delete(int id);
    }
}
