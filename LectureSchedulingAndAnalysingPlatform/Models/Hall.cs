using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LectureSchedulingAndAnalysingPlatform.Models
{
    public class Hall
    {
        [Key]
        //[ForeignKey("Hall")]
        public int Id { get; set; }
        public string Name { get; set; }

        [ForeignKey("Building")]
        public int? BuildingId { get; set; }
        public Building? Building { get; set; }

        [ForeignKey("PermissionType")]
        public int? PermissionTypeId { get; set; }
        public PermissionType? PermissionType { get; set; }

        public virtual Session? Session { get; set; }
        public virtual Reservation? Reservation { get; set; }
    }
}
