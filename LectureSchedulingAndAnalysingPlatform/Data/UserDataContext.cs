using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LectureSchedulingAndAnalysingPlatform.Models;
using Microsoft.EntityFrameworkCore;

namespace LectureSchedulingAndAnalysingPlatform.Data
{
    public class UserDataContext:DbContext
    {
        public UserDataContext(DbContextOptions<UserDataContext> options):base(options)
        {

        }
        public DbSet<User> Users { get; set; }
        public DbSet<Approval> A { get; set; }
        public DbSet<Building> Buildings { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Hall> Halls { get; set; }
        public DbSet<Permission> Permissions { get; set; }
        public DbSet<PermissionType> PermissionTypes { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Reserver> Reservers { get; set; }
        public DbSet<ReserverType> ReserverTypes { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Session> Sessions { get; set; }
        public DbSet<Subject> Subjects { get; set; }
    }
}
