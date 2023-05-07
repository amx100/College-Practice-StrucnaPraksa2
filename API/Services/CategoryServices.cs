using Application.Contracts.Service;
using Application.Data.Dto;
using System.Threading.Tasks;

namespace Application.Services
{
    public class CategoryServices : ICategoryService
    {
        public Task<ResponseDto> CreateCategory(CategoryCreateDto categoryDto)
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> DeleteCategory(int categoryId)
        {
            throw new System.NotImplementedException();
        }

        public Task<System.Collections.Generic.IEnumerable<CategoryReadOnlyDto>> GetAllCategories()
        {
            throw new System.NotImplementedException();
        }

        public Task<CategoryReadOnlyDto> GetCategoryById(int categoryId)
        {
            throw new System.NotImplementedException();
        }

        public Task<ResponseDto> UpdateCategory(int categoryId, CategoryUpdateDto categoryDto)
        {
            throw new System.NotImplementedException();
        }
    }
}
