using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LectureSchedulingAndAnalysingPlatform.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace LectureSchedulingAndAnalysingPlatform.Data
{
    public class UserDataContext:DbContext
    {
        public UserDataContext(DbContextOptions<UserDataContext> options):base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new RoleConfiguration());
            modelBuilder.ApplyConfiguration(new SubjectConfiguration());
            modelBuilder.ApplyConfiguration(new DepartmentConfiguration());
            modelBuilder.ApplyConfiguration(new BuildingConfiguration());
            modelBuilder.ApplyConfiguration(new HallConfiguration());
            modelBuilder.ApplyConfiguration(new HodConfiguration());
            modelBuilder.Entity<IdentityUserRole<string>>().HasKey(p => new { p.UserId, p.RoleId });        }

        public DbSet<User> Users { get; set; }
        public DbSet<Building> Buildings { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Hall> Halls { get; set; }
        public DbSet<Session> Sessions { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<SubjectUser> SubjectUsers { get; set; }
        public DbSet<Hod> Hods { get; set; }
        public DbSet<OnlineSession> OnlineSessions { get; set; }
    }
}
