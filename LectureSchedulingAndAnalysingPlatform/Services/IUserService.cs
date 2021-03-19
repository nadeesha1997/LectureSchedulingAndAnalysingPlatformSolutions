using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LectureSchedulingAndAnalysingPlatform.Models;

namespace LectureSchedulingAndAnalysingPlatform.Services
{
    public interface IUserService
    {
        public Task GetAll();
        public Task Get(string id);
        public Task Add(User newBook);
        public Task Update(string id, User book);
        public Task Delete(string id);
    }
}
