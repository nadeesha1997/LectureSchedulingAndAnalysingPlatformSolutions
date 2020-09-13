﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LectureSchedulingAndAnalysingPlatform.Models
{
    public class Building
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public Department Department { get; set; }
    }
}
