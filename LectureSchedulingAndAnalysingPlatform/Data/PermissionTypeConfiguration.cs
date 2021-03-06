using LectureSchedulingAndAnalysingPlatform.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LectureSchedulingAndAnalysingPlatform.Data
{
    public class PermissionTypeConfiguration : IEntityTypeConfiguration<PermissionType>
    {
        public void Configure(EntityTypeBuilder<PermissionType> builder)
        {
            builder.HasData(
            new PermissionType
            {
                Id = 1,
                Name = "Lecture Hall Building",
                Hod = false,
                Ar = false
            },
            new PermissionType
            {
                Id = 2,
                Name = "Department Building",
                Hod = true,
                Ar = false
            },
            new PermissionType
            {
                Id = 3,
                Name = "Administration Building",
                Hod = false,
                Ar = true
            },
            new PermissionType
            {
                Id = 4,
                Name = "Auditorium",
                Hod = false,
                Ar = true
            });
        }
    }
}

