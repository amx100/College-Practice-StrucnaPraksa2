using System.ComponentModel.DataAnnotations;

namespace Application.Data.Dto.Category
{
    public class CategoryCreateDto
    {
        [Required]
        public int Name { get; set; }
        [Required]
        public string Description { get; set; }

    }
}
