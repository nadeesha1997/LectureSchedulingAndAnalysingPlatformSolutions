﻿// <auto-generated />
using System;
using LectureSchedulingAndAnalysingPlatform.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace LectureSchedulingAndAnalysingPlatform.Migrations
{
    [DbContext(typeof(UserDataContext))]
    [Migration("20210315114306_role-added")]
    partial class roleadded
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("LectureSchedulingAndAnalysingPlatform.Models.Approval", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Approved")
                        .HasColumnType("bit");

                    b.Property<int?>("ApprovedById")
                        .HasColumnType("int");

                    b.Property<string>("ApprovedById1")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Note")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PermissionId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ApprovedById1");

                    b.HasIndex("PermissionId");

                    b.ToTable("A");
                });

            modelBuilder.Entity("LectureSchedulingAndAnalysingPlatform.Models.Building", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("DepartmentId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("DepartmentId");

                    b.ToTable("Buildings");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DepartmentId = 1,
                            Name = "Electrical and Information Engineering Department Building"
                        },
                        new
                        {
                            Id = 2,
                            DepartmentId = 2,
                            Name = "Civil and Environment Engineering Engineering Department Building"
                        },
                        new
                        {
                            Id = 3,
                            DepartmentId = 3,
                            Name = "Mechanical and Manufacturing Engineering Department Building"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Administration Building"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Lecture Hall"
                        });
                });

            modelBuilder.Entity("LectureSchedulingAndAnalysingPlatform.Models.Department", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Code")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Departments");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Code = "EIE",
                            Name = "Electrical and Information Engineering"
                        },
                        new
                        {
                            Id = 2,
                            Code = "CEE",
                            Name = "Civil and Environment Engineering"
                        },
                        new
                        {
                            Id = 3,
                            Code = "MME",
                            Name = "Mechanical and Manufacturing Engineering"
                        },
                        new
                        {
                            Id = 4,
                            Code = "IS",
                            Name = "Interdisciplinary Studies"
                        });
                });

            modelBuilder.Entity("LectureSchedulingAndAnalysingPlatform.Models.Hall", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("BuildingId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PermissionTypeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BuildingId");

                    b.HasIndex("PermissionTypeId");

                    b.ToTable("Halls");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BuildingId = 1,
                            Name = "ELR",
                            PermissionTypeId = 2
                        },
                        new
                        {
                            Id = 2,
                            BuildingId = 1,
                            Name = "EIE Computer Lab",
                            PermissionTypeId = 2
                        },
                        new
                        {
                            Id = 3,
                            BuildingId = 3,
                            Name = "MLR",
                            PermissionTypeId = 2
                        },
                        new
                        {
                            Id = 4,
                            BuildingId = 2,
                            Name = "CLR",
                            PermissionTypeId = 2
                        },
                        new
                        {
                            Id = 5,
                            BuildingId = 5,
                            Name = "LT1",
                            PermissionTypeId = 1
                        });
                });

            modelBuilder.Entity("LectureSchedulingAndAnalysingPlatform.Models.Lecturer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DeptId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("LecturerID")
                        .HasColumnType("int");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Lecturers");
                });

            modelBuilder.Entity("LectureSchedulingAndAnalysingPlatform.Models.Permission", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Notes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Permitted")
                        .HasColumnType("bit");

                    b.Property<DateTime>("PermittedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("PermittedTime")
                        .HasColumnType("datetime2");

                    b.Property<int?>("SessionId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SessionId")
                        .IsUnique()
                        .HasFilter("[SessionId] IS NOT NULL");

                    b.ToTable("Permissions");
                });

            modelBuilder.Entity("LectureSchedulingAndAnalysingPlatform.Models.PermissionType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Ar")
                        .HasColumnType("bit");

                    b.Property<bool>("Hod")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("PermissionTypes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Ar = false,
                            Hod = false,
                            Name = "Lecture Hall Building"
                        },
                        new
                        {
                            Id = 2,
                            Ar = false,
                            Hod = true,
                            Name = "Department Building"
                        },
                        new
                        {
                            Id = 3,
                            Ar = true,
                            Hod = false,
                            Name = "Administration Building"
                        },
                        new
                        {
                            Id = 4,
                            Ar = true,
                            Hod = false,
                            Name = "Auditorium"
                        });
                });

            modelBuilder.Entity("LectureSchedulingAndAnalysingPlatform.Models.Reservation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("EndTime")
                        .HasColumnType("datetime2");

                    b.Property<int?>("HallId")
                        .HasColumnType("int");

                    b.Property<bool>("Permitted")
                        .HasColumnType("bit");

                    b.Property<DateTime>("StartTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("HallId")
                        .IsUnique()
                        .HasFilter("[HallId] IS NOT NULL");

                    b.HasIndex("UserId");

                    b.ToTable("Reservations");
                });

            modelBuilder.Entity("LectureSchedulingAndAnalysingPlatform.Models.Reserver", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ReservationId")
                        .HasColumnType("int");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("ReservationId");

                    b.HasIndex("UserId");

                    b.ToTable("Reservers");
                });

            modelBuilder.Entity("LectureSchedulingAndAnalysingPlatform.Models.Session", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("EndDateTime")
                        .HasColumnType("datetime2");

                    b.Property<int?>("HallId")
                        .HasColumnType("int");

                    b.Property<bool>("Permitted")
                        .HasColumnType("bit");

                    b.Property<DateTime>("StartDateTime")
                        .HasColumnType("datetime2");

                    b.Property<int?>("SubjectId")
                        .HasColumnType("int");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("HallId");

                    b.HasIndex("SubjectId");

                    b.HasIndex("UserId");

                    b.ToTable("Sessions");
                });

            modelBuilder.Entity("LectureSchedulingAndAnalysingPlatform.Models.Subject", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Code")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Subjects");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Code = "CE1301 ",
                            Name = "Introduction to Civil Engineering"
                        },
                        new
                        {
                            Id = 2,
                            Code = "CE2302 ",
                            Name = "Mechanics of Materials"
                        },
                        new
                        {
                            Id = 3,
                            Code = "CE2201 ",
                            Name = "Fundamentals of Fluid Mechanics"
                        },
                        new
                        {
                            Id = 4,
                            Code = "CE3301 ",
                            Name = "Building Planning and Cost Estimating "
                        },
                        new
                        {
                            Id = 5,
                            Code = "CE3202 ",
                            Name = "Concrete Technology"
                        });
                });

            modelBuilder.Entity("LectureSchedulingAndAnalysingPlatform.Models.SubjectUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("SubjectId")
                        .HasColumnType("int");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("SubjectId");

                    b.HasIndex("UserId");

                    b.ToTable("SubjectUsers");
                });

            modelBuilder.Entity("LectureSchedulingAndAnalysingPlatform.Models.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DepartmentId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FullName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("ProfilePictureName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RegNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Role")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Semester")
                        .HasColumnType("int");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("DepartmentId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("IdentityRole");

                    b.HasData(
                        new
                        {
                            Id = "713ff50b-e431-4fc6-ae72-278a0ac412d5",
                            ConcurrencyStamp = "ed782914-2594-41c9-9b9f-b0073c4b48e1",
                            Name = "Teacher",
                            NormalizedName = "TEACHER"
                        },
                        new
                        {
                            Id = "f7e07c98-f313-455a-b63e-f26727685fe2",
                            ConcurrencyStamp = "e047a44e-442e-4263-bc1d-17be689dcac2",
                            Name = "Student",
                            NormalizedName = "STUDENT"
                        },
                        new
                        {
                            Id = "f4134c45-f452-4e23-9f86-94142d0733eb",
                            ConcurrencyStamp = "499ffd57-2710-4ce1-8f0a-cb82dc2daff9",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = "9f886034-e096-45c4-a567-82d109b6c815",
                            ConcurrencyStamp = "e8ddaa0a-89df-4160-8fc4-0a8983ee275b",
                            Name = "AR",
                            NormalizedName = "AR"
                        },
                        new
                        {
                            Id = "014a3fca-f75d-47a3-8cfd-ee3a8747a43b",
                            ConcurrencyStamp = "a83f4477-6f74-47ab-8180-b8a5a7e52608",
                            Name = "HOD",
                            NormalizedName = "HOD"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.ToTable("IdentityUserRole<string>");
                });

            modelBuilder.Entity("LectureSchedulingAndAnalysingPlatform.Models.Approval", b =>
                {
                    b.HasOne("LectureSchedulingAndAnalysingPlatform.Models.User", "ApprovedBy")
                        .WithMany()
                        .HasForeignKey("ApprovedById1");

                    b.HasOne("LectureSchedulingAndAnalysingPlatform.Models.Permission", "Permission")
                        .WithMany("Approvals")
                        .HasForeignKey("PermissionId");
                });

            modelBuilder.Entity("LectureSchedulingAndAnalysingPlatform.Models.Building", b =>
                {
                    b.HasOne("LectureSchedulingAndAnalysingPlatform.Models.Department", "Department")
                        .WithMany("Buildings")
                        .HasForeignKey("DepartmentId");
                });

            modelBuilder.Entity("LectureSchedulingAndAnalysingPlatform.Models.Hall", b =>
                {
                    b.HasOne("LectureSchedulingAndAnalysingPlatform.Models.Building", "Building")
                        .WithMany("Halls")
                        .HasForeignKey("BuildingId");

                    b.HasOne("LectureSchedulingAndAnalysingPlatform.Models.PermissionType", "PermissionType")
                        .WithMany("Halls")
                        .HasForeignKey("PermissionTypeId");
                });

            modelBuilder.Entity("LectureSchedulingAndAnalysingPlatform.Models.Permission", b =>
                {
                    b.HasOne("LectureSchedulingAndAnalysingPlatform.Models.Session", "Session")
                        .WithOne("Permission")
                        .HasForeignKey("LectureSchedulingAndAnalysingPlatform.Models.Permission", "SessionId");
                });

            modelBuilder.Entity("LectureSchedulingAndAnalysingPlatform.Models.Reservation", b =>
                {
                    b.HasOne("LectureSchedulingAndAnalysingPlatform.Models.Hall", "Hall")
                        .WithOne("Reservation")
                        .HasForeignKey("LectureSchedulingAndAnalysingPlatform.Models.Reservation", "HallId");

                    b.HasOne("LectureSchedulingAndAnalysingPlatform.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("LectureSchedulingAndAnalysingPlatform.Models.Reserver", b =>
                {
                    b.HasOne("LectureSchedulingAndAnalysingPlatform.Models.Reservation", "Reservation")
                        .WithMany()
                        .HasForeignKey("ReservationId");

                    b.HasOne("LectureSchedulingAndAnalysingPlatform.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("LectureSchedulingAndAnalysingPlatform.Models.Session", b =>
                {
                    b.HasOne("LectureSchedulingAndAnalysingPlatform.Models.Hall", "Hall")
                        .WithMany("Sessions")
                        .HasForeignKey("HallId");

                    b.HasOne("LectureSchedulingAndAnalysingPlatform.Models.Subject", "Subject")
                        .WithMany("Sessions")
                        .HasForeignKey("SubjectId");

                    b.HasOne("LectureSchedulingAndAnalysingPlatform.Models.User", "User")
                        .WithMany("Sessions")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("LectureSchedulingAndAnalysingPlatform.Models.SubjectUser", b =>
                {
                    b.HasOne("LectureSchedulingAndAnalysingPlatform.Models.Subject", "Subject")
                        .WithMany("SubjectUsers")
                        .HasForeignKey("SubjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LectureSchedulingAndAnalysingPlatform.Models.User", "User")
                        .WithMany("SubjectUsers")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("LectureSchedulingAndAnalysingPlatform.Models.User", b =>
                {
                    b.HasOne("LectureSchedulingAndAnalysingPlatform.Models.Department", "Department")
                        .WithMany("Users")
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
