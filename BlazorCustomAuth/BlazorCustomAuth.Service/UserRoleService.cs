using BlazorCustomAuth.Entities;
using BlazorCustomAuth.Repo;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorCustomAuth.Service
{
   public class UserRoleService:BaseService<UserRole>,IUserRoleService
    {
        private readonly IUserRoleRepository userRoleRepository;

        public UserRoleService(IUserRoleRepository userRoleRepository):base(userRoleRepository)
        {
            this.userRoleRepository = userRoleRepository;
        }
    }
}
