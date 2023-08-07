using Microsoft.EntityFrameworkCore;
using SQLTables.DBContext.ConfigTables;
using SQLTables.Domain.Entity;

namespace SQLTables.DBContext
{
    public class AppDbContext : DbContext
    {
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Author> Author { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<BuyBook> BuyBooks { get; set; }
        public DbSet<Buy> Buys { get; set; }
        public DbSet<BuyStep> BuySteps { get; set; } 
        public DbSet<City> Cities { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Step> Steps { get; set; }

        public AppDbContext(DbContextOptions options) : base(options)
        {
            Database.EnsureCreated();
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new BookConfig());
            modelBuilder.ApplyConfiguration(new BuyConfig());
            modelBuilder.ApplyConfiguration(new AuthorConfig());
            modelBuilder.ApplyConfiguration(new BuyBookConfig());
            modelBuilder.ApplyConfiguration(new BuyStepConfig());
            modelBuilder.ApplyConfiguration(new CityConfig());
            modelBuilder.ApplyConfiguration(new ClientConfig());
            modelBuilder.ApplyConfiguration(new GenreConfig());
            modelBuilder.ApplyConfiguration(new StepConfig());
        }
    }
}
