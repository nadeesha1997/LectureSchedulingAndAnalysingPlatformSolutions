using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LectureSchedulingAndAnalysingPlatform.Models
{
    public class OnlineSession
    {
        public int Id { get; set; }
        public string Link { get; set; }
        public string MeetingId { get; set; }
        public string Password { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        [ForeignKey("User")]
        public string? UserId { get; set; }
        public User? User { get; set; }
        [ForeignKey("Subject")]
        public int? SubjectId { get; set; }
        public Subject? Subject { get; set; }
    }
}
