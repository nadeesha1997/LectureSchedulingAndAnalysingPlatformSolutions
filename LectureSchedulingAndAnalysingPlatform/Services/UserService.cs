using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LectureSchedulingAndAnalysingPlatform.Data;
using LectureSchedulingAndAnalysingPlatform.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LectureSchedulingAndAnalysingPlatform.Services
{
    public class UserService:IUserService
    {
        //static List<User> Database = loadDB();

        //public static List<User> loadDB()
        //{
        //    List<User> temp = new List<User>();
        //    temp.Add(new User {});
        //    temp.Add(new User {});
        //    return temp;
        //}

        //public List<User> GetAll()
        //{
        //    return Database;
        //}

        //public User Get(int id)
        //{
        //    return Database.Find(user => user.Semester == id);
        //}

        //public void Add(User newUser)
        //{
        //    Database.Add(newUser);
        //}

        //public void Update(int id, User user)
        //{
        //    Database.Remove(Database.Find(user => user.Semester == id));
        //    user.Semester = id;
        //    Database.Add(user);
        //}

        //public void Delete(int id)
        //{
        //    Database.Remove(Database.Find(user => user.Semester == id));
        //}
        private readonly UserDataContext _context;
        private readonly IWebHostEnvironment _hostEnvironment;
        public UserService(UserDataContext context, IWebHostEnvironment hostEnvironment)
        {
            _context = context;
            this._hostEnvironment = hostEnvironment;
        }
        public async Task<ActionResult<IEnumerable<User>>> GetAll()
        {
            return await _context.Users.ToListAsync();
        }

        public async Task<ActionResult<User>> Get(string id)
        {
            var user = await _context.Users
                .Include(i => i.Department)
                //.Include(i=>i.SubjectUser)
                .Where(i => i.Id == id)
                .FirstOrDefaultAsync();

            if (user == null)
            {
                throw new NotImplementedException();
            }

            return user;
        }

        Task IUserService.Add(User newBook)
        {
            throw new NotImplementedException();
        }

        Task IUserService.Update(string id, User book)
        {
            throw new NotImplementedException();
        }

        Task IUserService.Delete(string id)
        {
            throw new NotImplementedException();
        }

        Task IUserService.GetAll()
        {
            throw new NotImplementedException();
        }

        Task IUserService.Get(string id)
        {
            throw new NotImplementedException();
        }
    }
}
