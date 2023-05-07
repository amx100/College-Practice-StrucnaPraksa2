using Application.Contracts.Repository;
using Application.Data;
using Application.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application.Repositories
{
    public class LineItemRepository : BaseRepository<LineItem>, ILineItemRepository
    { 
        public LineItemRepository(ApplicationDbContext context) : base(context) {}

        public void CreateLineItem(LineItem lineItem) => Create(lineItem);

        public void UpdateLineItem(LineItem lineItem) => Update(lineItem);

        public void DeleteLineItem(LineItem lineItem) => Delete(lineItem);

        public async Task<IEnumerable<LineItem>> GetAllLineItems() => await SelectAll().ToListAsync();

        public async Task<LineItem> GetLineItemById(int id) => await SelectByCondition(lineItem => lineItem.LineItemID == id).FirstOrDefaultAsync();
    }
}
