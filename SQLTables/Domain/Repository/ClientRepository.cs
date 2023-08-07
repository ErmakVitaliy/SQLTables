using SQLTables.DBContext;
using SQLTables.Domain.Entity;
using SQLTables.Domain.Interfaces;

namespace SQLTables.Domain.Repository
{
    public class ClientRepository : IBaseRepository<Client>
    {
        AppDbContext appDbContext;
        public ClientRepository(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }
        public void Create(Client item)
        {
            appDbContext.Clients.Add(item);
        }

        public void DeleteItem(int id)
        {
            var item = appDbContext.Clients.FirstOrDefault(x => x.Id == id);
            if (item != null)
            {
                appDbContext.Clients.Remove(item);
            }
        }

        public IQueryable<Client> GetAll()
        {
            return appDbContext.Clients;
        }

        public Client GetItem(int id)
        {
            return appDbContext.Clients.FirstOrDefault(x=>x.Id == id) ?? new Client();
        }

        public void Update(Client item)
        {
            appDbContext.Update(item);
            appDbContext.SaveChanges();
        }
    }
}
