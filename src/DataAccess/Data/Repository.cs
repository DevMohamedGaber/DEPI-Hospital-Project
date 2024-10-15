using DataAccess.Abstacts;
using DataAccess.Contexts;
using DataAccess.Interfaces;
using Microsoft.AspNetCore.Identity;

namespace DataAccess.Data
{
    public class Repository<T> : IRepository<T> where T : IdentityUser<uint>
    {
        protected readonly ApplicationContext context;

        public Repository(ApplicationContext context)
        {
            this.context = context;
        }

        public IQueryable<T> GetAll()
        {
            return context.Set<T>();
        }
        public T GetById(int id)
        {
            var entity = context.Set<T>().Where(x => x.Id == id) as T;
            return entity;
        }
        public void Create(T entity)
        {
            context.Set<T>().Add(entity);
            context.SaveChanges();
        }
        public void Update(T entity)
        {
            context.Set<T>().Update(entity);
            context.SaveChanges();
        }
        public void Delete(T entity)
        {
            context.Remove(entity);
            context.SaveChanges();
        }
        public void Delete(IEnumerable<T> entities)
        {
            context.Remove(entities);
            context.SaveChanges();
        }
    }
}
