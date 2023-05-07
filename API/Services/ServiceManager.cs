using Application.Contracts;
using Application.Contracts.Service;
using System;

namespace Application.Services
{
    public class ServiceManager : IServiceManager
    {
        private readonly Lazy<IProductService> _lazyProductService;


        public ServiceManager(IRepositoryManager repositoryManager)
        {
            _lazyProductService = new Lazy<IProductService>(() => new ProductService(repositoryManager));
        }

        public IProductService ProductService => _lazyProductService.Value;
    }
}
