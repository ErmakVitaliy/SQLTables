using SQLTables.DBContext;
using SQLTables.Domain.Entity;
using SQLTables.Domain.Interfaces;

namespace SQLTables.Domain.Repository
{
    public class BuyStepRepository : IBaseRepository<BuyStep>
    {
        AppDbContext appDbContext;
        public BuyStepRepository(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }
        public void Create(BuyStep item)
        {
            appDbContext.BuySteps.Add(item);
            appDbContext.SaveChanges();
        }

        public void DeleteItem(int id)
        {
            var item = appDbContext.BuySteps.FirstOrDefault(x => x.Id == id);
            if (item != null)
            {
                appDbContext.BuySteps.Remove(item);
            }
        }

        public IQueryable<BuyStep> GetAll()
        {
            return appDbContext.BuySteps;
        }

        public BuyStep GetItem(int id)
        {
            return appDbContext.BuySteps.FirstOrDefault(x => x.Id == id) ?? new BuyStep();
        }

        public void Update(BuyStep item)
        {
            appDbContext.Update(item);
            appDbContext.SaveChanges();
        }
    }
}
