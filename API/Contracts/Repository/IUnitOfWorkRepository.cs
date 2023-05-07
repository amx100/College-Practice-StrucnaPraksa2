using System.Threading.Tasks;

namespace Application.Contracts.Repository
{
    public interface IUnitOfWorkRepository
    {
        Task<int> SaveChangesAsync();
    }
}