using Grabble.Data.Domain;
using Grabble.Repository.Interface;
using System;
using System.Collections.Generic;

namespace Grabble.Services
{
    public class OrderService : IOrderService
    {
        private IRepository<Order> orderRespository;
        private Guid orderguid;

        public OrderService(IRepository<Order> orderrepository)
        {
            this.orderRespository = orderrepository;
            orderguid = Guid.NewGuid();
        }

        public void DeleteOrder(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Order> GetOrders()
        {
            return orderRespository.GetAll();
        }

        public Order GetOrder(int id)
        {
            return orderRespository.Get(id);
        }

        public void InsertOrder(Order order)
        {
            order.OrderGuid = orderguid;
            orderRespository.Insert(order);
        }

        public void UpdateOrder(Order order)
        {
            orderRespository.Update(order);
        }
    }
}
