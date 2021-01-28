using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.AccessControl;
using System.Threading.Tasks;

namespace LectureSchedulingAndAnalysingPlatform.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Regno { get; set; }
        public string Name { get; set; }
        //public ICollection<Role> Roles { get; set; }
        public int? RoleId { get; set; }
        public Role? Role { get; set; }
    }
}
