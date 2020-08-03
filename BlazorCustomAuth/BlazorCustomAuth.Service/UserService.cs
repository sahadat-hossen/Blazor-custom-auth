using BlazorCustomAuth.Entities;
using BlazorCustomAuth.Repo;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorCustomAuth.Service
{
   public class UserService:BaseService<User>,IUserService
    {
        private readonly IUserRepository userRepository;

        public UserService(IUserRepository  userRepository):base(userRepository)
        {
            this.userRepository = userRepository;
        }
    }
}
