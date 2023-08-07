using SQLTables.DBContext;
using SQLTables.Domain.Entity;
using SQLTables.Domain.Interfaces;

namespace SQLTables.Domain.Repository
{
    public class CityRepository : IBaseRepository<City>
    {
        AppDbContext appDbContext;
        public CityRepository(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }
        public void Create(City item)
        {
            appDbContext.Cities.Add(item);
            appDbContext.SaveChanges();
        }

        public void DeleteItem(int id)
        {
            var item = appDbContext.Cities.FirstOrDefault(x => x.Id == id);
            if (item != null)
            {
                appDbContext.Cities.Remove(item);
            }
        }

        public IQueryable<City> GetAll()
        {
            return appDbContext.Cities;
        }

        public City GetItem(int id)
        {
            return appDbContext.Cities.FirstOrDefault(x => x.Id == id) ?? new City();
        }

        public void Update(City item)
        {
            appDbContext.Update(item);
            appDbContext.SaveChanges();
        }
    }
}
