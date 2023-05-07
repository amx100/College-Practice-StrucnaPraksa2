using Application.Contracts.Repository;

namespace Application.Contracts
{
    public interface IRepositoryManager
    {
        IProductRepository ProductRepository { get; }
        ICategoryRepository CategoryRepository { get; }
        IOrderRepository OrderRepository { get; }
        ILineItemRepository LineItemRepository { get; }
        IUnitOfWorkRepository UnitOfWorkRepository { get; }
    }
}