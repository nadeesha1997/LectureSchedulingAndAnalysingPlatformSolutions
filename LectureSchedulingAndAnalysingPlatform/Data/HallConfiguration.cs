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
               Name = "DO1-A",
               BuildingId = 5,
               PermissionType = "null"
           },
                                new Hall
                                {
                                    Id = 2,
                                    Name = "DO1-B",
                                    BuildingId = 5,
                                    PermissionType = "null"
                                },


                                new Hall
                                {
                                    Id = 3,
                                    Name = " DO2-A ",
                                    BuildingId = 5,
                                    PermissionType = "null"
                                },

                                new Hall
                                {
                                    Id = 4,
                                    Name = " DO2-B",
                                    BuildingId = 5,
                                    PermissionType = "null"
                                },

                                new Hall
                                {
                                    Id = 5,
                                    Name = "LR1",
                                    BuildingId = 5,
                                    PermissionType = "null"
                                },

                                new Hall
                                {
                                    Id = 6,
                                    Name = "LR2",
                                    BuildingId = 5,
                                    PermissionType = "null"
                                },
                                new Hall
                                {
                                    Id = 7,
                                    Name = "LT1",
                                    BuildingId = 5,
                                    PermissionType = "null"
                                },

                                new Hall
                                {
                                    Id = 8,
                                    Name = "LT2",
                                    BuildingId = 5,
                                    PermissionType = "null"
                                },

                                new Hall
                                {
                                    Id = 9,
                                    Name = "NLH1",
                                    BuildingId = 5,
                                    PermissionType = "null"
                                },
                                new Hall
                                {
                                    Id = 10,
                                    Name = "NLH2",
                                    BuildingId = 5,
                                    PermissionType = "null"
                                },

                                new Hall
                                {
                                    Id = 11,
                                    Name = "IS-CC",
                                    BuildingId = 4,
                                    PermissionType = "isHOD"
                                },

                                new Hall
                                {
                                    Id = 12,
                                    Name = "ELEC-CC",
                                    BuildingId = 1,
                                    PermissionType = "elecHOD"
                                },

                                new Hall
                                {
                                    Id = 13,
                                    Name = "ELR",
                                    BuildingId = 1,
                                    PermissionType = " elecHOD "
                                },

                                new Hall
                                {
                                    Id = 14,
                                    Name = "CLR",
                                    BuildingId = 2,
                                    PermissionType = "civilHOD"
                                },

                                new Hall
                                {
                                    Id = 15,
                                    Name = "MLR",
                                    BuildingId = 3,
                                    PermissionType = "mechHOD"
                                },

                                new Hall
                                {
                                    Id = 16,
                                    Name = " IS-Seminor ",
                                    BuildingId = 4,
                                    PermissionType = "isHOD"
                                });
        }
    }
}


