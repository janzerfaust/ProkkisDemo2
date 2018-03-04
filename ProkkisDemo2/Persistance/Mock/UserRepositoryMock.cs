
using System.Threading.Tasks;
using ProkkisDemo2.Core;
using ProkkisDemo2.Core.Models;

namespace ProkkisDemo2.Persistance.Mock
{
    public class UserRepositoryMock : IUserRepository
    {
        public Task<bool> CreateUser(User user)
        {
            throw new System.NotImplementedException();
        }

        public Task<User> GetUserAsync(int id)
        {
            return Task.Run(() =>
            {
                return new User { Id = 1, Email = "mokki.mokkaaja@example.com", UserName = "mokker" };
            });
        }
    }
}
