using System.Threading.Tasks;

namespace Application.Contracts.Repository
{
    public interface IUnitOfWork
    {
        Task<int> SaveChangesAsync();
    }
}
