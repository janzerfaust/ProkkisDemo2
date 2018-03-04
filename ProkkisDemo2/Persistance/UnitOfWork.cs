using System.Threading.Tasks;
using ProkkisDemo2.Core;

namespace ProkkisDemo2.Persistance
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ProkkisDbContext context;

        public UnitOfWork(ProkkisDbContext context)
        {
            this.context = context;
        }

        public async Task SaveAsync()
        {
            await context.SaveChangesAsync();
        }
    }
}
