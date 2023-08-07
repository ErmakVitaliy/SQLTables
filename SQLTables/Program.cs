using Microsoft.EntityFrameworkCore;
using SQLTables.DBContext;
using SQLTables.Domain;
using SQLTables.Domain.Entity;
using SQLTables.Domain.Interfaces;
using SQLTables.Domain.Repository;

namespace SQLTables
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            string? connection = builder.Configuration.GetConnectionString("DefaultConnection");
            builder.Services.AddDbContext<AppDbContext>(option => option.UseSqlite(connection));

            builder.Services.AddTransient<IBaseRepository<Author>,AuthorRepository>();
            builder.Services.AddTransient<IBaseRepository<Book>, BookRepository>();
            builder.Services.AddTransient<IBaseRepository<BuyBook>, BuyBookRepository>();
            builder.Services.AddTransient<IBaseRepository<Buy>, BuyRepository>();
            builder.Services.AddTransient<IBaseRepository<BuyStep>, BuyStepRepository>();
            builder.Services.AddTransient<IBaseRepository<City>, CityRepository>();
            builder.Services.AddTransient<IBaseRepository<Client>, ClientRepository>();
            builder.Services.AddTransient<IBaseRepository<Genre>, GenreRepository>();
            builder.Services.AddTransient<IBaseRepository<Step>, StepRepository>();
            builder.Services.AddTransient<DataManager>();

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}