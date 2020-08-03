using BlazorCustomAuth.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BlazorCustomAuth.Entities
{
    [Table("RoleTasks")]
     public class RoleTask:Entry
     {
        public RoleTaskEnum Task { get; set; }
        public int UserRoleId { get; set; }
        [ForeignKey("UserRoleId")]
        public UserRole UserRole { get; set; }
    }
}
