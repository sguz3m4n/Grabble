using Grabble.Repository.Interface;
using Grabble.Repository.Repo;
using RestSharp;
using System;
using System.Collections.Generic;

namespace Grabble.Repository.REST
{
    public class GrabbleREST : IREST<T>
    {

        #region Construtor

        public GrabbleREST()
        {

        }


        #endregion

        #region Properties

        protected String Uri { get; set; }
        protected String Resource { get; set; }
        public String Parameters { get; set; }

        #endregion

        #region Methods


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
            throw new System.NotImplementedException();
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

        public RestRequest RestRequest()
        {
            var request = new RestRequest
            {
                Resource = this.Resource + this.Parameters
            };
            return request;
        }

        public RestClient RestClient()
        {
            var client = new RestClient();
            client.BaseUrl = new Uri(this.Uri);
            return client;
        }

        public RestClient RestClient(string uri)
        {
            var client = new RestClient();
            client.BaseUrl = new Uri(uri);
            return client;
        }

        public RestRequest RestRequest(string resource, T parameters)
        {
            var request = new RestRequest
            {
                Resource = resource.Trim() + parameters
            };
            return request;
        }

        public String RestTest()
        {
            return "REST api working";
        }

        #endregion
    }
}
