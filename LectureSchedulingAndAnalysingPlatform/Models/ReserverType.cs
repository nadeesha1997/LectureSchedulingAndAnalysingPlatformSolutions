using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.AccessControl;
using System.Threading.Tasks;

namespace LectureSchedulingAndAnalysingPlatform.Models
{
    public class ReserverType
    {
        [Key]
        public int Id { get; set; }
        public string Type { get; set; }
        public virtual Reserver Reserver { get; set; }
    }
}
