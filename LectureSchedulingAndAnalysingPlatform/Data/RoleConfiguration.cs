using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LectureSchedulingAndAnalysingPlatform.Data
{
    public class RoleConfiguration : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(
            new IdentityRole
            {
                Name = "Teacher",
                NormalizedName = "TEACHER"
            },
            new IdentityRole
            {
                Name = "Student",
                NormalizedName = "STUDENT"
            },
            new IdentityRole
            {
                Name = "Admin",
                NormalizedName = "ADMIN"
            },
            new IdentityRole
            {
                Name = "AR",
                NormalizedName = "AR"
            },
            new IdentityRole
            {
                Name = "HOD",
                NormalizedName = "HOD"
            });
        }
    }
}
