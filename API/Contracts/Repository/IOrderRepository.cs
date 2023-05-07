using Application.Data.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application.Contracts.Repository
{
    public interface IOrderRepository : IBaseRepository<Order>
    {
        Task<IEnumerable<Order>> GetAllOrders();
        Task<Order> GetOrderById(int id);
        void CreateOrder(Order order);
        void UpdateOrder(Order order);
        void DeleteOrder(Order order);
    }
}
