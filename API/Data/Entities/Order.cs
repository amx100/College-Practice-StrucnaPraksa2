using Application.Data.Enums;
using System.Collections.Generic;

namespace Application.Data.Entities
{
    public class Order
    {
        public int OrderID { get; set; }
        public string OrderNote { get; set; } = string.Empty;
        public decimal Total { get; set; }
        public OrderStatus Status { get; set; }
        public List<LineItem> LineItems { get; set; }
    }
}
