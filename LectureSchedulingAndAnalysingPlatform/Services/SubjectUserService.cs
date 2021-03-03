using LectureSchedulingAndAnalysingPlatform.Data;
using LectureSchedulingAndAnalysingPlatform.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LectureSchedulingAndAnalysingPlatform.Services
{
    public class SubjectUserService
    {
        private readonly UserDataContext _context;

        public SubjectUserService(UserDataContext context)
        {
            _context = context;
        }
        //public void addModule(string userId,int subjectId)
        //{
        //    User user = _context.Users.FirstOrDefault(s => s.Id == userId);
        //}
        public void Add(SubjectUser subjectUser)
        {
            _context.SubjectUsers.Add(subjectUser);
            _context.SaveChanges();
        }
        public List<SubjectUser> GetAll()
        {
            return _context.SubjectUsers
                .Include(i=>i.Subject)
                .Include(i=>i.User)
                .ToList();
        }
    }
}
