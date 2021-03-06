using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LectureSchedulingAndAnalysingPlatform.Models
{
    public class Session
    {
        [Key]
        //[ForeignKey("Session")]
        public int Id { get; set; }
        public DateTime StartDateTime { get; set; }
        public DateTime EndDateTime { get; set; }
        public bool Permitted { get; set; }

        [ForeignKey("Subject")]
        public int? SubjectId { get; set; }
        public Subject? Subject { get; set; }

        [ForeignKey("Hall")]
        public int? HallId { get; set; }
        public Hall? Hall { get; set; }

        [ForeignKey("User")]
        public string? UserId { get; set; }
        public User? User { get; set; }

        //public virtual Reservation? Reservation { get; set; }
        public virtual Permission? Permission { get; set; }
    }
}
