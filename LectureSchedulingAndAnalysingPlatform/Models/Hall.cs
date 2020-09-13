using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LectureSchedulingAndAnalysingPlatform.Models
{
    public class Hall
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Building Building { get; set; }
        public PermissionType Permission { get; set; }
    }
}
