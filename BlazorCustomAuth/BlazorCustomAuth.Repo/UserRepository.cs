using BlazorCustomAuth.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorCustomAuth.Repo
{
    public class UserRepository: BaseRepository<User>, IUserRepository
    {
        private readonly AppDbContext dbContext;

        public UserRepository(AppDbContext dbContext):base(dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<User> GetUserByUserNamePassword(string userName, string password)
        {
            return await this.dbContext.Users.Where(s => s.UserName.ToUpper() == userName.ToUpper() && s.Password.ToUpper()==password.ToUpper()).FirstOrDefaultAsync();
        }
    }
}
