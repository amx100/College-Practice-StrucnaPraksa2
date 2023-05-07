using Application.Contracts;
using Application.Contracts.Service;
using Application.Data.Dto;
using Application.Data.Dto.Product;
using Application.Data.Entities;
using Mapster;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application.Services
{
    public class ProductServices : IProductService
    {

        private readonly IRepositoryManager _repositoryManager;
        private readonly ResponseDto _response;

        public ProductServices (IRepositoryManager repositoryManager)
        {
            _repositoryManager = repositoryManager;
            _response = new();
        }



        public async Task<ResponseDto> CreateProduct(ProductCreateDto productDto)
        {
            var product = productDto.Adapt<Product>();
            _repositoryManager.ProductRepository.CreateProduct(product);
            var result = await _repositoryManager.UnitOfWorkRepository.SaveChangesAsync();
            if (result > 0)
            {
                _response.Data = product;
                return _response;
            }

            _response.IsSuccess = false;
            _response.DisplayMessage = "Error Creating Prodcut";
            return _response;
        }

        public async Task<ResponseDto> UpdatePRoduct(int productId, ProductUpdateDto productDto)
        {
            var productCheck = await _repositoryManager.ProductRepository.GetProductById(productId);
            if(productCheck is null)
            {
                _response.IsSuccess = false;
                _response.DisplayMessage = "Product not found in Database";
                return _response;
            }
            var product = productDto.Adapt<Product>();
            product.UpdatedAt = DateTime.Now;
            _repositoryManager.ProductRepository.Update(product);

            var result = await _repositoryManager.UnitOfWorkRepository.SaveChangesAsync();
            if (result > 0)
            {
                _response.Data = product;
                return _response;
            }
            _response.IsSuccess = false;
            _response.DisplayMessage = "Error Updating Product";
            return _response;
        }

        public async Task<bool> DeleteProduct(int productId)
        {
            var product = await _repositoryManager.ProductRepository.GetProductById(productId);
            if(product is not null)
            {
                _repositoryManager.ProductRepository.DeleteProduct(product);
                return await _repositoryManager.UnitOfWorkRepository.SaveChangesAsync() == 1;
            }

            return false;
        }

        public async Task<IEnumerable<ProductReadOnlyDto>> GetAllPRoducts()
        {
            var products = await _repositoryManager.ProductRepository.GetAllProducts();
            return products.Adapt<IEnumerable<ProductReadOnlyDto>>();
        }

        public async Task<ProdcutReadOnlyDto> GetProductById(int productId)
        {
            var product = await _repositoryManager.ProductRepository.GetProductById(productId);
            return product.Adapt<ProductReadOnlyDto>();
        }

        public Task<System.Collections.IEnumerable<ProductReadOnlyDto>> GetAllProducts()
        {
            throw new System.NotImplementedException();
        }

        public Task<ProductReadOnlyDto> GetProductById(int productId) => throw new System.NotImplementedException();

        Task<IEnumerable<ProductReadOnlyDto>> IProductService.GetAllProducts()
        {
            throw new NotImplementedException();
        }

        public Task<ResponseDto> UpdateProduct(int productId, ProductUpdateDto productDto)
        {
            throw new NotImplementedException();
        }
    }
}
