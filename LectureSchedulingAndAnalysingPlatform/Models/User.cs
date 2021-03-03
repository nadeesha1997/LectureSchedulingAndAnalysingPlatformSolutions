using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.AccessControl;
using System.Threading.Tasks;

namespace LectureSchedulingAndAnalysingPlatform.Models
{
    public class User:IdentityUser
    {
        public string RegNo { get; set; }
        //public string LecturerID { get; set; }
        //public string StudentID { get; set; }
        //public string EmpoyeeID { get; set; }
        public string FullName { get; set; }
        public int Semester { get; set; }
        [NotMapped]
        public IFormFile ImageFile { get; set; }
        public string ProfilePictureName { get; set; }
        public Department? Department { get; set; }
        //public SubjectUser? SubjectUser { get; set; }
        public virtual ICollection<SubjectUser> SubjectUsers { get; set; }

    }
}
