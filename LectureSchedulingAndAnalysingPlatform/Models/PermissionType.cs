using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LectureSchedulingAndAnalysingPlatform.Models
{
    public class PermissionType
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public bool Hod { get; set; }
        public bool Ar { get; set; }
        //public virtual Hall? Hall { get; set; }
        public ICollection<Hall> Halls { get; set; }
    }
}
