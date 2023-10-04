using HTT_WebApp_.Context;
using HTT_WebApp_.Models;
using Microsoft.EntityFrameworkCore;

namespace HTT_WebApp_.Services.Impl
{
    public class ProductService : IHTTAppService<Product>
    {
        private readonly HTTAppDbContext _db;

        public ProductService(HTTAppDbContext db)
        {
            _db = db;
        }
        public async Task<IEnumerable<Product>> GetAllAsync()
        {
            return await _db.Products.Include(p => p.Category).ToListAsync();
        }

        public async Task<Product?> GetByIdAsync(int id)
        {
            return await _db.Products.FirstOrDefaultAsync(x => x.Id == id);
        }        
    }
}
