using Domain.Contracts;
using Domain.Entities;
using Infrastructure.Persistence;
using System.Linq.Expressions;

namespace Application.Repositories
{
    public class ProductRepository : BaseRepository<Product>, IProductRepository
    {
        public ProductRepository(ApplicationDbContext context) : base(context) { }

        public void Create(Product entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Product entity)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Product> FindAll()
        {
            throw new NotImplementedException();
        }

        public IQueryable<Product> FindByCondition(Expression<Func<Product, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public void Update(Product entity)
        {
            throw new NotImplementedException();
        }
    }
}
