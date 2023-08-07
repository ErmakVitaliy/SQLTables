using SQLTables.DBContext;
using SQLTables.Domain.Entity;
using SQLTables.Domain.Interfaces;

namespace SQLTables.Domain.Repository
{
    public class BuyBookRepository : IBaseRepository<BuyBook>
    {
        AppDbContext appDbContext;
        public BuyBookRepository(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }
        public void Create(BuyBook item)
        {
            appDbContext.BuyBooks.Add(item);
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

        public IQueryable<BuyBook> GetAll()
        {
            return appDbContext.BuyBooks;
        }

        public BuyBook GetItem(int id)
        {
            return appDbContext.BuyBooks.FirstOrDefault(x => x.Id == id) ?? new BuyBook();
        }

        public void Update(BuyBook item)
        {
            appDbContext.Update(item);
            appDbContext.SaveChanges();
        }
    }
}
