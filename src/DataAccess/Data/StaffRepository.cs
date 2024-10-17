using DataAccess.Contexts;
using DataAccess.Entities;
using DataAccess.Interfaces;

namespace DataAccess.Data
{
    public class StaffRepository<T> : BaseRepository<T>, IStaffRepository<T> where T : Staff
    {
        public StaffRepository(ApplicationContext context) : base(context) { }

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
