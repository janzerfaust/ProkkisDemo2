using System.Threading.Tasks;
using ProkkisDemo2.Core;

namespace ProkkisDemo2.Persistance
{
    public class UnitOfWork : IUnitOfWork
    {
        //private readonly dbcontext

        public UnitOfWork()
        {
            // context = context
        }

        public async Task SaveAsync()
        {            
            await Task.Run(() => { });
        }
    }
}
