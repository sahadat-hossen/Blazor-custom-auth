using BlazorCustomAuth.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorCustomAuth.Repo
{
    public class UserRepository: BaseRepository<User>, IUserRepository
    {
        private readonly AppDbContext dbContext;

        public UserRepository(AppDbContext dbContext):base(dbContext)
        {
            this.dbContext = dbContext;
        }

    }
}
