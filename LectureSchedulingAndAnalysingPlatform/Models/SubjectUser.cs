using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LectureSchedulingAndAnalysingPlatform.Models
{
    public class SubjectUser
    {
        [Key]
        public int Id { get; set; }
        public ICollection<Subject> Subjects { get; set; }
        public ICollection<User> Users { get; set; }
    }
}
