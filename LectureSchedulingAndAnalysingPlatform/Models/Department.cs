﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LectureSchedulingAndAnalysingPlatform.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public virtual List<Building> Buildings { get; set; }
    }
}
