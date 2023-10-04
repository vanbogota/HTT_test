using HTT_WebApp_.Context;
using HTT_WebApp_.Models;
using Microsoft.EntityFrameworkCore;

namespace HTT_WebApp_.Services.Impl
{
    public class CategoryService : IHTTAppService<Category>
    {
        private readonly HTTAppDbContext _db;

        public CategoryService(HTTAppDbContext db)
        {
            _db = db;
        }
        public async Task<IEnumerable<Category>> GetAllAsync()
        {
            return await _db.Categories.ToListAsync();
        }

        public async Task<Category?> GetByIdAsync(int id)
        {
            return await _db.Categories.FirstOrDefaultAsync(c => c.Id == id);
        }
    }
}
