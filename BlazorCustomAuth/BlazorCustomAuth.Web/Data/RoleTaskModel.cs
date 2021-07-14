using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorCustomAuth.Web.Data
{
    public class RoleTaskModel
    {
        public bool IsCheck { get; set; }
        public string TaskName { get; set; }
        public string GroupName { get; set; }
        public string TaskValue { get; set; }
    }
}
