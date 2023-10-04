using System.ComponentModel.DataAnnotations;

namespace HTT_WebApp_DAL.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        public required string ProductName { get; set; }
        public required int CategoryId { get; set; }
        public required Category Category { get; set; }
    }
}
