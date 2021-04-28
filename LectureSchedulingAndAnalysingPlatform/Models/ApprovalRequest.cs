using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LectureSchedulingAndAnalysingPlatform.Models
{
    public class ApprovalRequest
    {
        public string ToEmail { get; set; }
        public string Hall { get; set; }
        public string Stime { get; set; }
        public string Etime { get; set; }
        public string Date { get; set; }
    }
}
