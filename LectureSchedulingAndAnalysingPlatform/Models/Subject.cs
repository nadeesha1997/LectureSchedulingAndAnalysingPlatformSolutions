using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LectureSchedulingAndAnalysingPlatform.Models
{
    public class Subject
    {
        [Key]
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        //public int Semester { get; set; }
        public ICollection<Session> Sessions { get; set; }
        public virtual ICollection<SubjectUser> SubjectUsers { get; set; }
    }
}
