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

        public async Task<User> GetUserAsync(int id)
        {
            return await context.Users.SingleOrDefaultAsync(u => u.Id == id);
        }
    }
}
