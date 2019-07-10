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
    }
}
