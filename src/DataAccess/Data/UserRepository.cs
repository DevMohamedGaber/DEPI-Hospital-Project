using DataAccess.Abstacts;
using DataAccess.Contexts;
using DataAccess.Interfaces;

namespace DataAccess.Data
{
    public class UserRepository<T> : BaseRepository<T>, IUserRepository<T> where T : User
    {
        public UserRepository(ApplicationContext context) : base(context) { }

        public T GetByName(string firstName, string lastName)
        {
            var user = context.Set<T>().Where(x => x.firstName == firstName && x.lastName == lastName) as T;
            return user;
        }
        public T GetById(int id)
        {
            var entity = context.Set<T>().Where(x => x.Id == id) as T;
            return entity;
        }
    }
}
