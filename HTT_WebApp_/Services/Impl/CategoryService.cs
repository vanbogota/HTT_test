﻿using AutoMapper;
using HTT_WebApp_.Models;
using HTT_WebApp_DAL.Context;
using Microsoft.EntityFrameworkCore;

namespace HTT_WebApp_.Services.Impl
{
    public class CategoryService : IHTTAppService<CategoryDto>
    {
        private readonly HTTAppDbContext _db;
        private readonly IMapper _mapper;

        public CategoryService(HTTAppDbContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }
        /// <summary>
        /// Returns all categories from database.
        /// </summary>
        /// <returns>List of CategoriesDto</returns>
        public async Task<IEnumerable<CategoryDto>> GetAllAsync()
        {
            var categories = await _db.Categories.ToListAsync();
            return _mapper.Map<List<CategoryDto>>(categories);                         
        }

        /// <summary>
        /// Returns category from databse by Id. 
        /// </summary>
        /// <param name="id"></param>
        /// <returns>CategoryDto</returns>
        public async Task<CategoryDto?> GetByIdAsync(int id)
        {
            var category = await _db.Categories.FirstOrDefaultAsync(c => c.Id == id);
            return _mapper.Map<CategoryDto>(category);
             
        }
    }
}
