using HTT_WebApp_.Mapper;
using HTT_WebApp_.Models;
using HTT_WebApp_.Services;
using HTT_WebApp_.Services.Impl;
using HTT_WebApp_DAL.Context;
using Microsoft.EntityFrameworkCore;
using AutoMapper;

namespace HTT_WebApp_
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

            #region Add services to the container.

            builder.Services.AddControllersWithViews();
            builder.Services.AddScoped<IHTTAppService<ProductDto>,ProductService>();
            builder.Services.AddScoped<IHTTAppService<CategoryDto>,CategoryService>();
                        
            #endregion

            #region Configure DB Context.

            builder.Services.AddDbContext<HTTAppDbContext>(options =>
            options.UseSqlServer(connectionString));
            
            #endregion

            #region Configure Mapper

            var mapperConfiguration = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<MappingProfile>();
            });
            var mapper = mapperConfiguration.CreateMapper();

            builder.Services.AddAutoMapper(typeof(Program));

            #endregion

            var app = builder.Build();

            #region Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            #endregion

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}");

            app.Run();
        }
    }
}