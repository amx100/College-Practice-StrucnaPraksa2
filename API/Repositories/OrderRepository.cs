using Application.Contracts.Repository;
using Application.Data;
using Application.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application.Repositories
{
    public class OrderRepository : BaseRepository<Order>, IOrderRepository
    { 
        public OrderRepository(ApplicationDbContext context) : base(context) {}

        public void CreateOrder(Order order) => Create(order);

        public void UpdateOrder(Order order) => Update(order);

        public void DeleteOrder(Order order) => Delete(order);

        public async Task<IEnumerable<Order>> GetAllOrders() => await SelectAll().ToListAsync();

        public async Task<Order> GetOrderById(int id) => await SelectByCondition(order => order.OrderID == id).FirstOrDefaultAsync();
    }
}
