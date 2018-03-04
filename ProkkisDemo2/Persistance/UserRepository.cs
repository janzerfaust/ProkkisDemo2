using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProkkisDemo2.Core;
using ProkkisDemo2.Core.Models;

namespace ProkkisDemo2.Persistance
{
    public class UserRepository : IUserRepository
    {
        ProkkisDbContext context;

        public UserRepository(ProkkisDbContext context)
        {
            this.context = context;
        }

        public async Task<bool> CreateUser(User user)
        {
            var usernameOrEmailExists = await context.Users.SingleOrDefaultAsync(x => 
                x.Email.ToLower() == user.Email.ToLower() || x.UserName.ToLower() == user.UserName.ToLower()
            );
            if(usernameOrEmailExists == null)
            {
                user.Id = await context.Users.DefaultIfEmpty().MaxAsync(u => u == null ? 0 : u.Id) + 1;
                await context.AddAsync<User>(user);                
                return true;
            }
            return false;
        }

        public async Task<User> GetUserAsync(int id)
        {
            return await context.Users.SingleOrDefaultAsync(u => u.Id == id);
        }
    }
}
