using LectureSchedulingAndAnalysingPlatform.Data;
using LectureSchedulingAndAnalysingPlatform.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LectureSchedulingAndAnalysingPlatform.Services
{
    public class SubjectService : ISubjectService
    {
        private readonly UserDataContext _context;

        public SubjectService(UserDataContext context)
        {
            _context = context;
        }
        public void Add(Subject subject)
        {
            _context.Subjects.Add(subject);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            _context.Subjects.Remove(GetOne(id));
            _context.SaveChanges();
        }

        public List<Subject> GetAll()
        {
            return _context.Subjects.ToList();
        }

        public List<Subject> GetByOneValue(string selector, string value)
        {
            if (selector == "department")
            {
                return _context.Subjects
                .Where(i => i.Code.Substring(0, 2) == value)
                .ToList();
            }
            else if (selector == "semester")
            {
                return _context.Subjects
                .Where(i => i.Code.Substring(2, 1) == value)
                .ToList();
            }
            else
            {
                throw new NotImplementedException();
            }
        }

        public List<Subject> GetByTwoValues(string selector1, string val1, string selector2, string val2)
        {
            if (selector1 == "department" && selector2=="semester")
            {
                return _context.Subjects
                .Where(i => i.Code.Substring(0, 2) == val1)
                .Where(i => i.Code.Substring(2, 1) == val2)
                .ToList();
            }
            else
            {
                throw new NotImplementedException();
            }
        }

        public Subject GetOne(int id)
        {
            return _context.Subjects
               .FirstOrDefault(i => i.Id == id);
        }

        public void Update(int id, Subject subject)
        {
            throw new NotImplementedException();
        }
    }
}
