using DataAccess.Abstacts;
using DataAccess.Contexts;
using DataAccess.Entities;
using DataAccess.Interfaces;

namespace DataAccess.Data
{
    public class UserRepository<T> : Repository<T>, IUserRepository<T> where T : User
    {
        public UserRepository(ApplicationContext context) : base(context) { }

        public T GetById(int id)
        {
            var user = context.Set<T>().Where(x => x.id == id) as T;
            return user;
        }

        public T GetByName(string firstName, string lastName)
        {
            var user = context.Set<T>().Where(x => x.firstName == firstName && x.lastName == lastName) as T;
            return user;
        }
    }
}
