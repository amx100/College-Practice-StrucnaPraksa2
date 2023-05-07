using Application.Contracts.Repository;
using Application.Data;
using Application.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application.Repositories
{
    public class CategoryRepository : BaseRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(ApplicationDbContext context) : base(context) { }

        public void CreateCategory(Category category) => Create(category);

        public void UpdateCategory(Category category) => Update(category);

        public void DeleteCategory(Category category) => Delete(category);

        public async Task<IEnumerable<Category>> GetAllCategories() => await SelectAll().ToListAsync();

        public async Task<Category> GetCategoryById(int id) => await SelectByCondition(category => category.CategoryID == id).FirstOrDefaultAsync();
    }
}
