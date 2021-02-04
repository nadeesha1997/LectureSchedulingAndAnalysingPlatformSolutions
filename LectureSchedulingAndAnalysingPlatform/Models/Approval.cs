using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LectureSchedulingAndAnalysingPlatform.Models
{
    public class Approval
    {
        [Key]
        public int Id { get; set; }
        public bool Approved { get; set; }
        public string Note { get; set; }

        [ForeignKey("User")]
        public int? ApprovedById { get; set; }
        public User ApprovedBy { get; set; }

        [ForeignKey("Permission")]
        public int? PermissionId { get; set; }
        public Permission? Permission { get; set; }

    }
}
