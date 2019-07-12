using System.Collections.Generic;
using System.Linq;
using Grabble.Data.Domain;
using Grabble.Repository.Context;
using Microsoft.EntityFrameworkCore;

namespace Grabble.Repository.Interface
{
    public class Repository<T>: IRepository<T> where T : BaseEntity
    {
        private readonly OrderDbContext context;
        private DbSet<T> entities;
        readonly string errorMessage = string.Empty;

        public Repository(OrderDbContext _context)
        {
            this.context = _context;
            entities = _context.Set<T>();
        }

        public void Delete(T entity)
        {
            throw new System.NotImplementedException();
        }

        public bool Exists(int id)
        {
            throw new System.NotImplementedException();
        }

        public T Get(long id)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<T> GetAll()
        {
            return entities.AsEnumerable();
        }

        public List<string> GetListAll()
        {
            throw new System.NotImplementedException();
        }

        public void Insert(T entity)
        {
            throw new System.NotImplementedException();
        }

        public void Remove(T entity)
        {
            throw new System.NotImplementedException();
        }

        public void SaveChanges()
        {
            throw new System.NotImplementedException();
        }

        public void Update(T entity)
        {
            throw new System.NotImplementedException();
        }
    }
}
