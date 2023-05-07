using Application.Data.Dto;
using Application.Data.Dto.Product;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application.Contracts.Service
{
    public interface IProductService
    {
        Task<IEnumerable<ProductReadOnlyDto>> GetAllProducts();
        Task<ProductReadOnlyDto> GetProductById(int productId);
        Task<ResponseDto> CreateProduct(ProductCreateDto productDto);
        Task<ResponseDto> UpdateProduct(int productId, ProductUpdateDto productDto);
        Task<bool> DeleteProduct(int productId);
    }
}
