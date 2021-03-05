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
    [Migration("20210305124215_temp")]
    partial class temp
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

                    b.Property<int?>("ReserverId")
                        .HasColumnType("int");

                    b.Property<int?>("SessionId")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartTime")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("HallId")
                        .IsUnique()
                        .HasFilter("[HallId] IS NOT NULL");

                    b.HasIndex("ReserverId")
                        .IsUnique()
                        .HasFilter("[ReserverId] IS NOT NULL");

                    b.HasIndex("SessionId")
                        .IsUnique()
                        .HasFilter("[SessionId] IS NOT NULL");

                    b.ToTable("Reservations");
                });

            modelBuilder.Entity("LectureSchedulingAndAnalysingPlatform.Models.Reserver", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Reservers");
                });

            modelBuilder.Entity("LectureSchedulingAndAnalysingPlatform.Models.Session", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("EndTime")
                        .HasColumnType("datetime2");

                    b.Property<int?>("HallId")
                        .HasColumnType("int");

                    b.Property<bool>("Permitted")
                        .HasColumnType("bit");

                    b.Property<DateTime>("StartTime")
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
                            Id = "0c6722ac-8e68-4cb8-83d6-a8f9ad5553f0",
                            ConcurrencyStamp = "d0294e28-8aa9-4e61-b371-e9cb99d618b2",
                            Name = "Teacher",
                            NormalizedName = "TEACHER"
                        },
                        new
                        {
                            Id = "69ca4e40-9066-4093-b439-80f9410b8221",
                            ConcurrencyStamp = "a1df3b27-7b94-4c53-aa01-4ff53174b498",
                            Name = "Student",
                            NormalizedName = "STUDENT"
                        },
                        new
                        {
                            Id = "329afd41-f0b5-48c4-940a-2c1228282092",
                            ConcurrencyStamp = "24bdd163-c300-4696-b92a-57550b17eaa8",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = "2fd7c7a0-790c-43d9-ae60-b03b87557e75",
                            ConcurrencyStamp = "af9edf9e-747f-409f-9766-2e0f6a1078ab",
                            Name = "AR",
                            NormalizedName = "AR"
                        },
                        new
                        {
                            Id = "c0522212-550b-4678-b519-14616686afa4",
                            ConcurrencyStamp = "bc4be5d9-cdf2-4533-bdc8-09f3059a5b55",
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

                    b.HasOne("LectureSchedulingAndAnalysingPlatform.Models.Reserver", "Reserver")
                        .WithOne("Reservation")
                        .HasForeignKey("LectureSchedulingAndAnalysingPlatform.Models.Reservation", "ReserverId");

                    b.HasOne("LectureSchedulingAndAnalysingPlatform.Models.Session", "Session")
                        .WithOne("Reservation")
                        .HasForeignKey("LectureSchedulingAndAnalysingPlatform.Models.Reservation", "SessionId");
                });

            modelBuilder.Entity("LectureSchedulingAndAnalysingPlatform.Models.Reserver", b =>
                {
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
