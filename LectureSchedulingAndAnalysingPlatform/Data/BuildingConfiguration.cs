using LectureSchedulingAndAnalysingPlatform.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LectureSchedulingAndAnalysingPlatform.Data
{
    public class BuildingConfiguration: IEntityTypeConfiguration<Building>
    {
        public void Configure(EntityTypeBuilder<Building> builder)
        {
            builder.HasData(
            new Building
            {
                Id = 1,
                Name = "Electrical and Information Engineering Department Building",
                DepartmentId = 1
            },
            new Building
            {
                Id = 2,
                Name = "Civil and Environment Engineering Engineering Department Building",
                DepartmentId = 2
            },
            new Building
            {
                Id = 3,
                Name = "Mechanical and Manufacturing Engineering Department Building",
                DepartmentId = 3
            },
            new Building
            {
                Id = 4,
                Name = "Administration Building"
            },
            new Building
            {
                Id = 5,
                Name = "Lecture Hall"
            });
        }
    }
}
