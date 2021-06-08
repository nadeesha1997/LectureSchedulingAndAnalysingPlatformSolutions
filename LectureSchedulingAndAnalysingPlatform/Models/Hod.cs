using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LectureSchedulingAndAnalysingPlatform.Models
{
    public class Hod
    {
        public int Id { get; set; }
        public string ElectricalMail { get; set; }
        public string CivilMail { get; set; }
        public string MechanicalMail { get; set; }
        public string ArMail { get; set; }
    }
}
