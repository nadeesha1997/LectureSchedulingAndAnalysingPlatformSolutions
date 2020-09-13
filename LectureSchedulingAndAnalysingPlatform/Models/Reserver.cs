using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Threading.Tasks;

namespace LectureSchedulingAndAnalysingPlatform.Models
{
    public class Reserver
    {
        public int Id { get; set; }
        public ReserverType Type { get; set; }
        public User User { get; set; }
        
    }
}
