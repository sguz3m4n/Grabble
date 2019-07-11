using Grabble.Repository.Repo;
using Grabble.Repository.REST;
using System;

namespace Grabble.Services
{
    public class OrderService
    {
        public String RestTest { get; set; }
        public OrderService()
        {
            var test = new GrabbleREST();
            RestTest = test.RestTest();
        }

        #region Properties
        public GrabbleRepo GrabbleRepo { get; set; }
        public GrabbleREST GrabbleREST { get; set; }
        #endregion

    }
}
