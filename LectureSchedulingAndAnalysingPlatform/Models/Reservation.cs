using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LectureSchedulingAndAnalysingPlatform.Models
{
    public class Reservation
    {
        [Key]
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public bool Permitted { get; set; }

        [ForeignKey("Reserver")]
        public int? ReserverId { get; set; }
        public Reserver? Reserver { get; set; }

        [ForeignKey("Hall")]
        public int? HallId { get; set; }
        public Hall? Hall { get; set; }

        [ForeignKey("Session")]
        public int? SessionId { get; set; }
        public Session? Session { get; set; }

    }
}
