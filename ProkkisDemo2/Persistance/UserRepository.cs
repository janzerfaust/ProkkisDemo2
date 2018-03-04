using System.Threading.Tasks;
using ProkkisDemo2.Core;
using ProkkisDemo2.Core.Models;

namespace ProkkisDemo2.Persistance
{
    public class UserRepository : IUserRepository
    {
        // dbcontext

        public Task<User> GetUser(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}
