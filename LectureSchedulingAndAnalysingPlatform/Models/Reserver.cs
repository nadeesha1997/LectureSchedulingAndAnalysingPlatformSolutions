using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.AccessControl;
using System.Threading.Tasks;

namespace LectureSchedulingAndAnalysingPlatform.Models
{
    public class Reserver
    {
        [Key]
        //[ForeignKey("Reserver")]
        public int Id { get; set; }
        //[ForeignKey("ReserverType")]
        //public int? ReserverTypeId { get; set; }
        //public ReserverType? Type { get; set; }
        //[ForeignKey("User")]
        //public int? UserId { get; set; }
        public User? User { get; set; }
        public virtual Reservation? Reservation { get; set; }

    }
}
