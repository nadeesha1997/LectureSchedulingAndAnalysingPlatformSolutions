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
    [Migration("20210305194152_data-seed-3")]
    partial class dataseed3
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

                    b.HasIndex("HallId")
                        .IsUnique()
                        .HasFilter("[HallId] IS NOT NULL");

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

                    b.Property<int?>("DepartmentId")
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
                            Id = "0e257bbc-2783-4bad-b249-a5d196968f51",
                            ConcurrencyStamp = "19b769bb-fed4-40e4-9ecb-dfd631461c7f",
                            Name = "Teacher",
                            NormalizedName = "TEACHER"
                        },
                        new
                        {
                            Id = "f59d608f-8896-4597-ba00-5eb5b5946c49",
                            ConcurrencyStamp = "661c0d60-a7c7-472c-a914-5122bd0e6cfc",
                            Name = "Student",
                            NormalizedName = "STUDENT"
                        },
                        new
                        {
                            Id = "9d2cfaa4-bd06-4622-9762-8f8f6e074030",
                            ConcurrencyStamp = "f1cddd01-d698-4706-b0a9-e1a2b39bbba6",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = "7aeaf1d9-06d6-4e09-95d6-8ae9e7adf597",
                            ConcurrencyStamp = "741df160-abd1-4446-9f93-780310633e25",
                            Name = "AR",
                            NormalizedName = "AR"
                        },
                        new
                        {
                            Id = "1b1da069-cde8-49f5-affc-90f0dcd4b0cc",
                            ConcurrencyStamp = "224d3890-d9a8-4cf3-9bb2-f6f04692c5f2",
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
                        .WithOne("Session")
                        .HasForeignKey("LectureSchedulingAndAnalysingPlatform.Models.Session", "HallId");

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
                        .HasForeignKey("DepartmentId");
                });
#pragma warning restore 612, 618
        }
    }
}