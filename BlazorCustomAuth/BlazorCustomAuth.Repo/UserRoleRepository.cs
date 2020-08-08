using BlazorCustomAuth.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorCustomAuth.Repo
{
   public class UserRoleRepository:BaseRepository<UserRole>,IUserRoleRepository
    {
        private readonly AppDbContext context;

        public UserRoleRepository(AppDbContext context):base(context)
        {
            this.context = context;
        }
       
    }
}
