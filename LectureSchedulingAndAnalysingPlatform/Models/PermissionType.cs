using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LectureSchedulingAndAnalysingPlatform.Models
{
    public class PermissionType
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool Hod { get; set; }
        public bool Ar { get; set; }
    }
}
