using Application.Data.Dto;
using Application.Data.Dto.Category;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application.Contracts.Service
{
    public interface ICategoryService
    {
        Task<IEnumerable<CategoryReadOnlyDto>> GetAllCategories();
        Task<CategoryReadOnlyDto> GetCategoryById(int categoryId);
        Task<ResponseDto> CreateCategory(CategoryCreateDto categoryDto);
        Task<ResponseDto> UpdateCategory(int categoryId, CategoryUpdateDto categoryDto);
        Task<bool> DeleteCategory(int categoryId);
    }
}
