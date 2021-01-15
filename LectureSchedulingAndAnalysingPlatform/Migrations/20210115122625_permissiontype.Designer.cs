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
    [Migration("20210115122625_permissiontype")]
    partial class permissiontype
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

                    b.Property<string>("Note")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PermissionId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ApprovedById");

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

                    b.Property<int>("PermissionTypeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BuildingId");

                    b.HasIndex("PermissionTypeId")
                        .IsUnique();

                    b.ToTable("Halls");
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

                    b.Property<int>("SessionId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SessionId")
                        .IsUnique();

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

                    b.Property<int>("HallId")
                        .HasColumnType("int");

                    b.Property<bool>("Permitted")
                        .HasColumnType("bit");

                    b.Property<int>("ReserverId")
                        .HasColumnType("int");

                    b.Property<int>("SessionId")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartTime")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("HallId")
                        .IsUnique();

                    b.HasIndex("ReserverId")
                        .IsUnique();

                    b.HasIndex("SessionId")
                        .IsUnique();

                    b.ToTable("Reservations");
                });

            modelBuilder.Entity("LectureSchedulingAndAnalysingPlatform.Models.Reserver", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ReserverTypeId")
                        .HasColumnType("int");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ReserverTypeId")
                        .IsUnique();

                    b.HasIndex("UserId");

                    b.ToTable("Reservers");
                });

            modelBuilder.Entity("LectureSchedulingAndAnalysingPlatform.Models.ReserverType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ReserverTypes");
                });

            modelBuilder.Entity("LectureSchedulingAndAnalysingPlatform.Models.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Roles");
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

                    b.Property<DateTime>("StartTime")
                        .HasColumnType("datetime2");

                    b.Property<int?>("SubjectId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("HallId")
                        .IsUnique()
                        .HasFilter("[HallId] IS NOT NULL");

                    b.HasIndex("SubjectId");

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

            modelBuilder.Entity("LectureSchedulingAndAnalysingPlatform.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Regno")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("LectureSchedulingAndAnalysingPlatform.Models.Approval", b =>
                {
                    b.HasOne("LectureSchedulingAndAnalysingPlatform.Models.User", "ApprovedBy")
                        .WithMany()
                        .HasForeignKey("ApprovedById");

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
                        .WithOne("Hall")
                        .HasForeignKey("LectureSchedulingAndAnalysingPlatform.Models.Hall", "PermissionTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("LectureSchedulingAndAnalysingPlatform.Models.Permission", b =>
                {
                    b.HasOne("LectureSchedulingAndAnalysingPlatform.Models.Session", "Session")
                        .WithOne("Permission")
                        .HasForeignKey("LectureSchedulingAndAnalysingPlatform.Models.Permission", "SessionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("LectureSchedulingAndAnalysingPlatform.Models.Reservation", b =>
                {
                    b.HasOne("LectureSchedulingAndAnalysingPlatform.Models.Hall", "Hall")
                        .WithOne("Reservation")
                        .HasForeignKey("LectureSchedulingAndAnalysingPlatform.Models.Reservation", "HallId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LectureSchedulingAndAnalysingPlatform.Models.Reserver", "Reserver")
                        .WithOne("Reservation")
                        .HasForeignKey("LectureSchedulingAndAnalysingPlatform.Models.Reservation", "ReserverId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LectureSchedulingAndAnalysingPlatform.Models.Session", "Session")
                        .WithOne("Reservation")
                        .HasForeignKey("LectureSchedulingAndAnalysingPlatform.Models.Reservation", "SessionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("LectureSchedulingAndAnalysingPlatform.Models.Reserver", b =>
                {
                    b.HasOne("LectureSchedulingAndAnalysingPlatform.Models.ReserverType", "Type")
                        .WithOne("Reserver")
                        .HasForeignKey("LectureSchedulingAndAnalysingPlatform.Models.Reserver", "ReserverTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LectureSchedulingAndAnalysingPlatform.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("LectureSchedulingAndAnalysingPlatform.Models.Role", b =>
                {
                    b.HasOne("LectureSchedulingAndAnalysingPlatform.Models.User", null)
                        .WithMany("Roles")
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
                });
#pragma warning restore 612, 618
        }
    }
}
