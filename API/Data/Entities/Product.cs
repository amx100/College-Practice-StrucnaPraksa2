using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Application.Data.Entities
{
    public class Product
    {
        public int ProductID { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; }

        public override string ToString()
        {
            return $"{Name} ------- {Price}";
        }
    }
}
