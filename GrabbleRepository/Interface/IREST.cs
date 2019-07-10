using RestSharp;
using System;
using System.Collections.Generic;

namespace Grabble.Repository.Interface
{
    public interface IREST<T>
    {
        IEnumerable<T> GetAll();
        List<String> GetListAll();
        T Get(long id);
        Boolean Exists(int id);
        void Insert(T entity);
        void Update(T entity);
        void Delete(T entity);
        void Remove(T entity);
        void SaveChanges();
        String RestTest();
        RestClient RestClient();
        RestRequest RestRequest();
        RestClient RestClient(String uri);
        RestRequest RestRequest(String resource, T parameters);
    }
}
