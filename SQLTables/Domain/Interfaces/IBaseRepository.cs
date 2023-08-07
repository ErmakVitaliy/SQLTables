namespace SQLTables.Domain.Interfaces
{
    public interface IBaseRepository<T>
        where T : class
    {
        public IQueryable<T> GetAll();
        public T GetItem(int id);
        public void DeleteItem(int id);
        public void Create(T item);
        public void Update(T item);
    }
}
