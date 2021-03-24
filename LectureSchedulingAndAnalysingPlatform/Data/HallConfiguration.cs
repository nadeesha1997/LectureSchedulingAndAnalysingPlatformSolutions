//using LectureSchedulingAndAnalysingPlatform.Models;
//using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore.Metadata.Builders;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;

//namespace LectureSchedulingAndAnalysingPlatform.Data
//{
//    public class HallConfiguration: IEntityTypeConfiguration<Hall>
//    {
//        public void Configure(EntityTypeBuilder<Hall> builder)
//        {
//            builder.HasData(
//            new Building
//            {
//                Id = 1,
//                Name = "Electrical and Information Engineering Department Building",
//                DepartmentId = 1
//            },
//            new Building
//            {
//                Id = 2,
//                Name = "Civil and Environment Engineering Engineering Department Building",
//                DepartmentId = 2
//            },
//            new Building
//            {
//                Id = 3,
//                Name = "Mechanical and Manufacturing Engineering Department Building",
//                DepartmentId = 3
//            },
//            new Building
//            {
//                Id = 4,
//                Name = "Administration Building"
//            },
//            new Building
//            {
//                Id = 5,
//                Name = "Lecture Hall"
//            });
//        }

//        public void Configure(EntityTypeBuilder<Hall> builder)
//        {
//            throw new NotImplementedException();
//        }
//    }
//}

using LectureSchedulingAndAnalysingPlatform.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LectureSchedulingAndAnalysingPlatform.Data
{
    public class HallConfiguration : IEntityTypeConfiguration<Hall>
    {
        public void Configure(EntityTypeBuilder<Hall> builder)
        {
            builder.HasData(
            new Hall
            {
                Id = 1,
                Name = "ELR",
                BuildingId = 1,
                PermissionType="elecHOD"
            },
            new Hall
            {
                Id = 2,
                Name = "EIE Computer Lab",
                BuildingId = 1,
                PermissionType = "elecHOD"
            },
            new Hall
            {
                Id = 3,
                Name = "MLR",
                BuildingId = 3,
                PermissionType = "mechHOD"
            },
            new Hall
            {
                Id = 4,
                Name = "CLR",
                BuildingId = 2,
                PermissionType = "civilHOD"
            },
            new Hall
            {
                Id = 5,
                Name = "LT1",
                BuildingId = 5,
                PermissionType = null
            });
        }
    }
}

