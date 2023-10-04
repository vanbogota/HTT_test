using System.ComponentModel.DataAnnotations;

namespace HTT_WebApp_DAL.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        public required string CategoryName { get; set; }
    }
}
