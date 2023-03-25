using Domain.Enums;

namespace Domain.Entities
{
    public class Order
    {
        public int OrderId { get; set; }
        public string OrderNote { get; set; } = string.Empty;
        public decimal Total { get; set; }
        public OrderStatus Status { get; set; }
        public List<LineItem> LineItems { get; set; }
    }
}
