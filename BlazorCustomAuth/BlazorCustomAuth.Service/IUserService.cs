using BlazorCustomAuth.Entities;
using System;
using System.Threading.Tasks;

namespace BlazorCustomAuth.Service
{
    public interface IUserService:IBaseService<User>
    {
        Task<User> GetUserByUserNamePassword(string userName,string password);
    }
}