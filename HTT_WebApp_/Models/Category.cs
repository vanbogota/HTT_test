using System.ComponentModel.DataAnnotations;

namespace HTT_WebApp_.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        public required string CategoryName { get; set; }
    }
}
