using BlazorCustomAuth.Entities;
using System.Threading.Tasks;

namespace BlazorCustomAuth.Repo
{
    public interface IUserRepository : IBaseRepository<User>
    {
        Task<User> GetUserByUserNamePassword(string userName, string password);
    }
}