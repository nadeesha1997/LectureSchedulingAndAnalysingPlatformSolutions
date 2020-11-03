using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LectureSchedulingAndAnalysingPlatform.Models
{
    public class Reservation
    {
        public int Id { get; set; }
        public Reserver Reserver { get; set; }
        public Hall Hall { get; set; }
        public DateTime Date { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public Session Session { get; set; }
        public bool Permitted { get; set; }
    }
}
