using ProkkisDemo2.Core.Models;
using System.Threading.Tasks;

namespace ProkkisDemo2.Core
{
    public interface IUserRepository
    {
        Task<User> GetUserAsync(int id);
    }
}
