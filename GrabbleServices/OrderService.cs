using System;
using System.Collections.Generic;
using System.Text;
using Grabble.Data.Domain.Order;
using Grabble.Repository.Interface;

namespace Grabble.Services
{
    public class OrderService : IOrderService
    {
      private  IRepository<Order> orderRespository;

        public OrderService(IRepository<Order> orderrepository)
        {
            this.orderRespository = orderrepository;
        }

        public void DeleteOrder(int id)
        {
            throw new NotImplementedException();
        }

        public Order GetUser(int id)
        {
            return orderRespository.Get(id);
        }

        public void InsertOrder(Order order)
        {
             orderRespository.Insert(order);
        }

        public void UpdateOrder(Order order)
        {
            orderRespository.Update(order);
        }
    }
}
