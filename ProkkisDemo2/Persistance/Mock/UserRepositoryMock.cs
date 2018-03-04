
using System.Threading.Tasks;
using ProkkisDemo2.Core;
using ProkkisDemo2.Core.Models;

namespace ProkkisDemo2.Persistance.Mock
{
    public class UserRepositoryMock : IUserRepository
    {
        public Task<User> GetUser(int id)
        {
            return Task.Run(() =>
            {
                return new User { Id = 1, Email = "mokki.mokkaaja@example.com", UserName = "mokker" };
            });
        }
    }
}
