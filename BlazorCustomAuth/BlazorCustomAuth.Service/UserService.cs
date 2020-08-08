using BlazorCustomAuth.Entities;
using BlazorCustomAuth.Repo;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BlazorCustomAuth.Service
{
   public class UserService:BaseService<User>,IUserService
    {
        private readonly IUserRepository userRepository;

        public UserService(IUserRepository  userRepository):base(userRepository)
        {
            this.userRepository = userRepository;
        }

        public async Task<User> GetUserByUserNamePassword(string userName, string password)
        {
            return await this.userRepository.GetUserByUserNamePassword(userName,password);
        }
    }
}
