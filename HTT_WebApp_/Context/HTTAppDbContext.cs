using HTT_WebApp_.Models;
using Microsoft.EntityFrameworkCore;

namespace HTT_WebApp_.Context
{
    public class HTTAppDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public HTTAppDbContext(DbContextOptions<HTTAppDbContext> options): base(options) { }
        
    }
}
