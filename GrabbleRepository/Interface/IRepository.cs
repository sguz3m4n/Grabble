using System;
using System.Collections.Generic;

namespace Grabble.Repository.Interface
{
    public interface IRepository<T>
    {
        IEnumerable<T> GetAll();
        List<String> GetListAll();
        Boolean Exists(int id);
        T Get(long id);
        void Insert(T entity);
        void Update(T entity);
        void Delete(T entity);
        void Remove(T entity);
        void SaveChanges();
    }
}
