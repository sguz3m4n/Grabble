using Grabble.Data.Domain;
using System;
using System.Collections.Generic;

namespace Grabble.Repository.Interface
{
    public interface IRepository<T> where T : BaseEntity
    {
        #region Properties

        #endregion

        #region Methods

        IEnumerable<T> GetAll();
        T Get(int id);
        void Insert(T entity);
        void Update(T entity);
        void Delete(T entity);
        void Remove(T entity);
        void SaveChanges();

        #endregion

    }
}
