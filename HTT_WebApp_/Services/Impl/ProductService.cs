using AutoMapper;
using HTT_WebApp_.Models;
using HTT_WebApp_DAL.Context;
using Microsoft.EntityFrameworkCore;

namespace HTT_WebApp_.Services.Impl
{
    public class ProductService : IHTTAppService<ProductDto>
    {
        private readonly HTTAppDbContext _db;
        private readonly IMapper _mapper;

        public ProductService(HTTAppDbContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }
        public async Task<IEnumerable<ProductDto>> GetAllAsync()
        {
            var products = await _db.Products.Include(p => p.Category).ToListAsync();
            return _mapper.Map<List<ProductDto>>(products);
             
        }

        public async Task<ProductDto?> GetByIdAsync(int id)
        {
            var product = await _db.Products.FirstOrDefaultAsync(x => x.Id == id);
            return _mapper.Map<ProductDto?>(product);
        }        
    }
}
