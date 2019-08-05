using Grabble.Data.Domain;
using Grabble.Repository.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Grabble.Repository
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly ApplicationContext context;
        private DbSet<T> entities;
        String errorMessage = string.Empty;

        public Repository(ApplicationContext context)
        {
            this.context = context;
            entities = context.Set<T>();
        }

        public void Delete(T entity)
        {
            throw new NotImplementedException();
        }

        public bool Exists(int id)
        {
            bool exists = false;
            if (entities.SingleOrDefault(s => s.Id == id) != null)
            {
                exists = true;
            }
            return exists;
        }

        public T Get(int id)
        {
            return entities.SingleOrDefault(s => s.Id == id);
        }

        public IEnumerable<T> GetAll()
        {
            return entities.AsEnumerable();
        }

        public List<string> GetListAll()
        {
            return null;
        }

        public void Insert(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            entities.Add(entity);
            context.SaveChanges();
        }

        public void Remove(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            entities.Remove(entity);
        }

        public void Update(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            entities.Update(entity);
            context.SaveChanges();
        }

        public void SaveChanges()
        {
            context.SaveChanges();
        }
    }
}
