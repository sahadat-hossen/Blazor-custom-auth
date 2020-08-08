using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorCustomAuth.Common
{
    public static  class Functions
    {
        public static string JoinRoles(params string[] roles)
        {
            return string.Join(",", roles);
        }
    }
}
