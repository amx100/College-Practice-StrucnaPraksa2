using Application.Contracts;
using Application.Data;
using Application.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Application.Repositories
{
    public class ProductRepository : BaseRepository<Product>, IProductRepository
    {
        public ProductRepository(ApplicationDbContext context) : base(context) { }

        public void CreateProduct(Product product)
        {
            Create(product);

        }

        public void DeleteProduct(Product product)
        {
            Delete(product);
        }

        public async Task<IEnumerable<Product>> GetAllProducts()
        {
            return await SelectAll().ToListAsync();
        }

        public async Task<Product> GetProductById(int id)
        {
            return await SelectByCondition(product => product.ProductID == id).FirstOrDefaultAsync();
        }

        public void UpdateProduct(Product product)
        {
            Update(product);
        }
    }
}
