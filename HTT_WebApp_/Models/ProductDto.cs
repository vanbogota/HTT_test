using System.ComponentModel.DataAnnotations;

namespace HTT_WebApp_.Models
{
    public class ProductDto
    {
        [Key]
        public int Id { get; set; }
        public required string ProductName { get; set; }
        public required int CategoryId { get; set; }
        public required CategoryDto Category { get; set; }
    }
}
