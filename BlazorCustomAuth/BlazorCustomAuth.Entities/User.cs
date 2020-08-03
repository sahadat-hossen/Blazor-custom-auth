using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BlazorCustomAuth.Entities
{
    [Table("Users")]
    public  class User:Entry
    {
        public string FullName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int RoleId { get; set; }
        [ForeignKey("RoleId")]
        public UserRole Role { get; set; }
    }
}
