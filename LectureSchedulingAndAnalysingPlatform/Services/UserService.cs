using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LectureSchedulingAndAnalysingPlatform.Models;

namespace LectureSchedulingAndAnalysingPlatform.Services
{
    public class UserService:IUserService
    {
        static List<User> Database = loadDB();

        public static List<User> loadDB()
        {
            List<User> temp = new List<User>();
            temp.Add(new User {});
            temp.Add(new User {});
            return temp;
        }

        public List<User> GetAll()
        {
            return Database;
        }

        public User Get(int id)
        {
            return Database.Find(user => user.Semester == id);
        }

        public void Add(User newUser)
        {
            Database.Add(newUser);
        }

        public void Update(int id, User user)
        {
            Database.Remove(Database.Find(user => user.Semester == id));
            user.Semester = id;
            Database.Add(user);
        }

        public void Delete(int id)
        {
            Database.Remove(Database.Find(user => user.Semester == id));
        }
    }
}
