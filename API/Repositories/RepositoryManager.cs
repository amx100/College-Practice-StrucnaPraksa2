using Application.Contracts;
using Application.Contracts.Repository;
using Application.Data;
using System;

namespace Application.Repositories
{
    public class RepositoryManager : IRepositoryManager
    {
        private readonly Lazy<IProductRepository> _lazyProductRepository;
        private readonly Lazy<ICategoryRepository> _lazyCategoryRepository;
        private readonly Lazy<IOrderRepository> _lazyOrderRepository;
        private readonly Lazy<ILineItemRepository> _lazyLineItemRepository;
        private readonly Lazy<IUnitOfWorkRepository> _lazyUnitOfWork;

        public RepositoryManager(ApplicationDbContext context)
        {
            _lazyProductRepository = new Lazy<IProductRepository>(() => new ProductRepository(context));
            _lazyCategoryRepository = new Lazy<ICategoryRepository>(() => new CategoryRepository(context));
            _lazyOrderRepository = new Lazy<IOrderRepository>(() => new OrderRepository(context));
            _lazyLineItemRepository = new Lazy<ILineItemRepository>(() => new LineItemRepository(context));
            _lazyUnitOfWork = new Lazy<IUnitOfWorkRepository>(() => new UnitOfWorkRepository(context));
        }

        public IProductRepository ProductRepository => _lazyProductRepository.Value;
        public ICategoryRepository CategoryRepository => _lazyCategoryRepository.Value;
        public IOrderRepository OrderRepository => _lazyOrderRepository.Value;
        public ILineItemRepository LineItemRepository => _lazyLineItemRepository.Value;
        public IUnitOfWorkRepository UnitOfWorkRepository => _lazyUnitOfWork.Value;
    }
}