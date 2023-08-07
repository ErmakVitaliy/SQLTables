using SQLTables.DBContext;
using SQLTables.Domain.Entity;
using SQLTables.Domain.Interfaces;

namespace SQLTables.Domain.Repository
{
    public class GenreRepository : IBaseRepository<Genre>
    {
        AppDbContext appDbContext;
        public GenreRepository(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }
        public void Create(Genre item)
        {
            appDbContext.Genres.Add(item);
        }

        public void DeleteItem(int id)
        {
            var item = appDbContext.Genres.FirstOrDefault(x => x.Id == id);
            if (item != null)
            {
                appDbContext.Genres.Remove(item);
            }
        }

        public IQueryable<Genre> GetAll()
        {
            return appDbContext.Genres;
        }

        public Genre GetItem(int id)
        {
            return appDbContext.Genres.FirstOrDefault(x => x.Id == id) ?? new Genre();
        }

        public void Update(Genre item)
        {
            appDbContext.Update(item);
            appDbContext.SaveChanges();
        }
    }
}
