using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LectureSchedulingAndAnalysingPlatform.Models;

namespace LectureSchedulingAndAnalysingPlatform.Services
{
    public interface IUserService
    {
        public List<User> GetAll();
        public User Get(int id);
        public void Add(User newBook);
        public void Update(int id, User book);
        public void Delete(int id);
    }
}
