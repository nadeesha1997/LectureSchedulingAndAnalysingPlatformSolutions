using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LectureSchedulingAndAnalysingPlatform.Models
{
    public class Session
    {
        public int Id { get; set; }
        public  Subject Subject { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime dateTime { get; set; }
        public Hall Hall { get; set; }
    }
}
