using Application.Data.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application.Contracts.Repository
{
    public interface ICategoryRepository : IBaseRepository<Category>
    {
        Task<IEnumerable<Category>> GetAllCategories();
        Task<Category> GetCategoryById(int id);
        void CreateCategory(Category category);
        void UpdateCategory(Category category);
        void DeleteCategory(Category category);
    }
}
