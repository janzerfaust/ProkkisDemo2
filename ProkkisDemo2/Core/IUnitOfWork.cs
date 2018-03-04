using System.Threading.Tasks;

namespace ProkkisDemo2.Core
{
    interface IUnitOfWork
    {
        Task SaveAsync();
    }
}
