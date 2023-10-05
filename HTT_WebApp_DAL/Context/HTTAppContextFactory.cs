using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace HTT_WebApp_DAL.Context
{
    public class HTTAppContextFactory : IDesignTimeDbContextFactory<HTTAppDbContext>
    {
        public HTTAppDbContext CreateDbContext(string[] args)
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var optionsBuilder = new DbContextOptionsBuilder<HTTAppDbContext>();

            optionsBuilder.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));

            return new HTTAppDbContext(optionsBuilder.Options);
        }
    }
}
