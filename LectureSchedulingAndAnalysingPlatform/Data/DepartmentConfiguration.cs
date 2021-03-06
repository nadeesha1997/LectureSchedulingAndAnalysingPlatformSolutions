using LectureSchedulingAndAnalysingPlatform.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LectureSchedulingAndAnalysingPlatform.Data
{
    public class DepartmentConfiguration: IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
            builder.HasData(
            new Department
            {
                Id = 1,
                Name = "Electrical and Information Engineering",
                Code = "EIE"
            },
            new Department
            {
                Id = 2,
                Name = "Civil and Environment Engineering",
                Code = "CEE"
            },
            new Department
            {
                Id = 3,
                Name = "Mechanical and Manufacturing Engineering",
                Code = "MME"
            },
            new Department
            {
                Id = 4,
                Name = "Interdisciplinary Studies",
                Code = "IS"
            });
        }
    }
}
