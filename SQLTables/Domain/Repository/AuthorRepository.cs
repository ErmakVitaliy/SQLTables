using SQLTables.DBContext;
using SQLTables.Domain.Entity;
using SQLTables.Domain.Interfaces;

namespace SQLTables.Domain.Repository
{
    public class AuthorRepository : IBaseRepository<Author>
    {
        AppDbContext appDbContext;
        public AuthorRepository(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }
        public void Create(Author item)
        {
            appDbContext.Author.Add(item);
            appDbContext.SaveChanges();
        }

        public void DeleteItem(int id)
        {
            var item = appDbContext.Author.FirstOrDefault(x => x.Id == id);
            if (item != null)
            {
                appDbContext.Author.Remove(item);
            }
        }

        public IQueryable<Author> GetAll()
        {
            return appDbContext.Author;
        }

        public Author GetItem(int id)
        {
            return appDbContext.Author.FirstOrDefault(x => x.Id == id) ?? new Author();
        }

        public void Update(Author item)
        {
            appDbContext.Update(item);
            appDbContext.SaveChanges();
        }
    }
}
