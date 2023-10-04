using HTT_WebApp_.Context;
using HTT_WebApp_.Models;
using HTT_WebApp_.Services;
using HTT_WebApp_.Services.Impl;
using Microsoft.EntityFrameworkCore;

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
            builder.Services.AddScoped<IHTTAppService<Product>,ProductService>();
            builder.Services.AddScoped<IHTTAppService<Category>,CategoryService>();

            #endregion

            #region Configure DB Context.

            builder.Services.AddDbContext<HTTAppDbContext>(options =>
            options.UseSqlServer(connectionString), ServiceLifetime.Singleton);

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
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}