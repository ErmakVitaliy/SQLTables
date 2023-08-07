using SQLTables.DBContext;
using SQLTables.Domain.Entity;
using SQLTables.Domain.Interfaces;

namespace SQLTables.Domain.Repository
{
    public class BuyRepository : IBaseRepository<Buy>
    {
        AppDbContext appDbContext;
        public BuyRepository(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }
        public void Create(Buy item)
        {
            appDbContext.Buys.Add(item);
            appDbContext.SaveChanges();
        }

        public void DeleteItem(int id)
        {
            var item = appDbContext.Buys.FirstOrDefault(x => x.Id == id);
            if (item != null)
            {
                appDbContext.Buys.Remove(item);
            }
        }

        public IQueryable<Buy> GetAll()
        {
            return appDbContext.Buys;
        }

        public Buy GetItem(int id)
        {
            return appDbContext.Buys.FirstOrDefault(x => x.Id == id) ?? new Buy();
        }

        public void Update(Buy item)
        {
            appDbContext.Update(item);
            appDbContext.SaveChanges();
        }
    }
}
