using HTT_WebApp_DAL.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace HTT_WebApp_DAL.Context
{
    public class HTTAppDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public HTTAppDbContext(DbContextOptions<HTTAppDbContext> options) : base(options) { }
       
    }
}
