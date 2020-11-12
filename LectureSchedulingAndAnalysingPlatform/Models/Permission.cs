using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LectureSchedulingAndAnalysingPlatform.Models
{
    public class Permission
    {
        public int Id { get; set; }
        public Session Session { get; set; }
        public DateTime PermittedDate { get; set; }
        public DateTime PermittedTime { get; set; }
        public bool Permitted { get; set; }
        public string notes { get; set; }
        public virtual List<Approval> Approvals { get; set; }
    }
}
