using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        public Department? Department { get; set; }
        public SubjectUser? SubjectUser { get; set; }

    }
}
