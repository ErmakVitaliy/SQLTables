using SQLTables.DBContext;
using SQLTables.Domain.Entity;
using SQLTables.Domain.Interfaces;

namespace SQLTables.Domain.Repository
{
    public class BookRepository : IBaseRepository<Book>
    {
        AppDbContext appDbContext;
        public BookRepository(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }
        public void Create(Book item)
        {
            appDbContext.Books.Add(item);
            appDbContext.SaveChanges();
        }

        public void DeleteItem(int id)
        {
            var item = appDbContext.Books.FirstOrDefault(x => x.Id == id);
            if (item != null)
            {
                appDbContext.Books.Remove(item);
            }
        }

        public IQueryable<Book> GetAll()
        {
            return appDbContext.Books;
        }

        public Book GetItem(int id)
        {
            return appDbContext.Books.FirstOrDefault(x => x.Id == id) ?? new Book();
        }

        public void Update(Book item)
        {
            appDbContext.Update(item);
            appDbContext.SaveChanges();
        }
    }
}
