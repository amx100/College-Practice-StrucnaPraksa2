using Application.Data.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application.Contracts.Repository
{
    public interface ILineItemRepository : IBaseRepository<LineItem>
    {
        Task<IEnumerable<LineItem>> GetAllLineItems();
        Task<LineItem> GetLineItemById(int id);
        void CreateLineItem(LineItem lineItem);
        void UpdateLineItem(LineItem lineItem);
        void DeleteLineItem(LineItem lineItem);
    }
}
