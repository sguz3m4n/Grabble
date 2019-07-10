using Grabble.Repository.Context;
using Grabble.Repository.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Grabble.Repository.Repo
{
    public class GrabbleRepo : IRepository<T>
    {
        #region Properties

        private readonly OrderDbContext context;
        private DbSet<T> entities;
        readonly string errorMessage = string.Empty;

        #endregion

        #region Constructor

        public GrabbleRepo(OrderDbContext _context)
        {
            this.context = _context;
            entities = _context.Set<T>();
        }

        #endregion

        #region Methods

        public void Delete(T entity)
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

        public void SaveChanges()
        {
            context.SaveChanges();
        }

        public void Update(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            context.SaveChanges();
        }

        public bool Exists(int id)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
