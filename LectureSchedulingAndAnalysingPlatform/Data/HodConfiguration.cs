using LectureSchedulingAndAnalysingPlatform.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LectureSchedulingAndAnalysingPlatform.Data
{
    public class HodConfiguration: IEntityTypeConfiguration<Hod>
    {
        public void Configure(EntityTypeBuilder<Hod> builder)
        {
            builder.HasData(
            new Hod
            {
                Id=1,
                ElectricalMail="nadeeshamadhushan9@gmail.com",
                CivilMail= "nadeeshamadhushan9@gmail.com",
                MechanicalMail= "nadeeshamadhushan9@gmail.com",
                ArMail= "nadeeshamadhushan9@gmail.com"
            });
        }
    }
}
