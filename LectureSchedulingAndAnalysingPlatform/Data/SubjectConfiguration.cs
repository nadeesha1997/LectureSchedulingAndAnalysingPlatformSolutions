using LectureSchedulingAndAnalysingPlatform.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LectureSchedulingAndAnalysingPlatform.Data
{
    public class SubjectConfiguration: IEntityTypeConfiguration<Subject>
    {
        public void Configure(EntityTypeBuilder<Subject> builder)
        {
            builder.HasData(
            new Subject
            {
                Id = 1,
                Name = "Introduction to Civil Engineering",
                Code = "CE1301 "
            },
            new Subject
                {
                Id = 2,
                Name = "Mechanics of Materials",
                Code = "CE2302 "
            },
            new Subject
            {
                Id = 3,
                Name = "Fundamentals of Fluid Mechanics",
                Code = "CE2201 "
            },
            new Subject
            {
                Id = 4,
                Name = "Building Planning and Cost Estimating ",
                Code = "CE3301 "
            },
            new Subject
            {
                Id = 5,
                Name = "Concrete Technology",
                Code = "CE3202 "
            });
        }
    }
}
