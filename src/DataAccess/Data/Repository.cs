﻿using DataAccess.Abstacts;
using DataAccess.Contexts;

namespace DataAccess.Data
{
    public class Repository<T> : BaseRepository<T> where T : BaseEntity
    {
        public Repository(ApplicationContext context) : base(context) { }

        public T GetById(int id)
        {
            var entity = context.Set<T>().Where(x => x.Id == id) as T;
            return entity;
        }
    }
}
