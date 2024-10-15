namespace DataAccess.Interfaces
{
    public interface IRepository<T> where T : class
    {
        // basic CRUD ops
        IQueryable<T> GetAll();
        T GetById(int id);
        void Create(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
