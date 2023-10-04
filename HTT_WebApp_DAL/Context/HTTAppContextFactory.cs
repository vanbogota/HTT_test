using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace HTT_WebApp_DAL.Context
{
    public class HTTAppContextFactory : IDesignTimeDbContextFactory<HTTAppDbContext>
    {
        public HTTAppDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<HTTAppDbContext>();
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=HTTWebApp2");

            return new HTTAppDbContext(optionsBuilder.Options);
        }
    }
}
