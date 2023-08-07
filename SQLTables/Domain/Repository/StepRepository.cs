using SQLTables.DBContext;
using SQLTables.Domain.Entity;
using SQLTables.Domain.Interfaces;

namespace SQLTables.Domain.Repository
{
    public class StepRepository : IBaseRepository<Step>
    {
        AppDbContext appDbContext;
        public StepRepository(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }
        public void Create(Step item)
        {
            appDbContext.Steps.Add(item);
            appDbContext.SaveChanges();
        }

        public void DeleteItem(int id)
        {
            var item = appDbContext.Genres.FirstOrDefault(x => x.Id == id);
            if (item != null)
            {
                appDbContext.Genres.Remove(item);
            }
        }

        public IQueryable<Step> GetAll()
        {
            return appDbContext.Steps;
        }

        public Step GetItem(int id)
        {
            return appDbContext.Steps.FirstOrDefault(x => x.Id == id) ?? new Step();
        }

        public void Update(Step item)
        {
            appDbContext.Update(item);
            appDbContext.SaveChanges();
        }
    }
}
