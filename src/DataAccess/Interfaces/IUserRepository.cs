namespace DataAccess.Interfaces
{
    public interface IUserRepository<T> : IRepository<T> where T : class
    {
        public T GetById(int id);
        public T GetByName(string firstName, string lastName);
    }
}
