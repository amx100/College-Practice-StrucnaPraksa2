using Application.Contracts.Repository;
using Application.Data;
using System.Threading.Tasks;

namespace Application.Repositories
{
    public class UnitOfWorkRepository : IUnitOfWorkRepository
    {
        private readonly ApplicationDbContext _context;

        public UnitOfWorkRepository(ApplicationDbContext context) => _context = context;

        public Task<int> SaveChangesAsync() => _context.SaveChangesAsync();
    }
}