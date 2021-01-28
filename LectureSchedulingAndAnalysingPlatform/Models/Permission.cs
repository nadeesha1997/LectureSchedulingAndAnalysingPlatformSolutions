using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LectureSchedulingAndAnalysingPlatform.Models
{
    public class Permission
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("Session")]
        public int? SessionId { get; set; }
        public Session? Session { get; set; }

        public DateTime PermittedDate { get; set; }
        public DateTime PermittedTime { get; set; }
        public bool Permitted { get; set; }
        public string Notes { get; set; }
        public ICollection<Approval> Approvals { get; set; }
    }

}
