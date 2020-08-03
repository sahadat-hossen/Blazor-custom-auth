using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BlazorCustomAuth.Entities
{
    [Table("UserRoles")]
    public class UserRole:Entry
    {
        public string RoleName { get; set; }
        public List<RoleTask> RoleTasks { get; set; }
    }
}
