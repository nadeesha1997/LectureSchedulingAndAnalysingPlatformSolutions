using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LectureSchedulingAndAnalysingPlatform.Models
{
    public class Approval
    {

        public int Id { get; set; }
        public User ApprovedBy { get; set; }
        public bool Approved { get; set; }
        public string note { get; set; }
        public Permission Permission { get; set; }

    }
}
