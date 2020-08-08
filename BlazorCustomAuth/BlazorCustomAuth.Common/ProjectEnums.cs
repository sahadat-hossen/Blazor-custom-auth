using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorCustomAuth.Common
{
    public enum StatusEnum:int
    {
        Active =1,
        Inactive=0
    }
    public static class RoleTaskList 
    {
        //SuperAdmin
        public static string SuperAdmin => "SuperAdmin";
        public static class User
        {
            public static string Add => "User.Add";
            public static string Edit => "User.Edit";
            public static string Delete => "User.Delete";
            public static string Details => "User.Details";

        }

        public static class UserRole
        {
            public static string Add => "UserRole.Add";
            public static string Edit => "UserRole.Edit";
            public static string Delete => "UserRole.Delete";
            public static string Details => "UserRole.Details";
        }


    }
}
