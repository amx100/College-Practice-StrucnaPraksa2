using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Application.Data.Dto.Product
{
    public class ProductUpdateDto
    {
        [Required]
        public int ProductID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        [Precision(18, 2)]
        public decimal Price { get; set; }
        [Required]
        public int Quantity { get; set; }
    }
}
