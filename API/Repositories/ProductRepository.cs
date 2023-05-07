using Application.Contracts.Repository;
using Application.Data;
using Application.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application.Repositories
{
    public class ProductRepository : BaseRepository<Product>, IProductRepository
    { 
        public ProductRepository(ApplicationDbContext context) : base(context) {}

        public void CreateProduct(Product product) => Create(product);

        public void UpdateProduct(Product product) => Update(product);

        public void DeleteProduct(Product product) => Delete(product);

        public async Task<IEnumerable<Product>> GetAllProducts() => await SelectAll().ToListAsync();

        public async Task<Product> GetProductById(int id) => await SelectByCondition(product => product.ProductID == id).FirstOrDefaultAsync();
    }
}
