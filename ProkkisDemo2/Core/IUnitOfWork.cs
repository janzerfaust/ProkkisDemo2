using System.Threading.Tasks;

namespace ProkkisDemo2.Core
{
    public interface IUnitOfWork
    {
        Task SaveAsync();
    }
}
