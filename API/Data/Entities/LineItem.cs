namespace Application.Data.Entities
{
    public class LineItem
    {
        public int LineItemID { get; set; }
        public int ProductID { get; set; }
        public Product Product { get; set; }
        public int Quantity { get; set; }
        public decimal PriceExTax { get; set; }
        public decimal PriceIncTax { get; set; }
        public decimal Tax { get; set; }
    }
}
