using Cake_AppBE.Models;
using System.Threading.Tasks;

namespace Cake_AppBE.IRepository
{
    public interface IUserRepository
    {
        Task<User> GetUserByUserName(string userName);
        Task<User> Create(User user, string password);
        Task<User> Authenticate(string username, string password);
    }
}
