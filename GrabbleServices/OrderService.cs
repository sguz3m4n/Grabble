using System;
using System.Collections.Generic;
using System.Text;
using Grabble.Data.Domain.Order;
using Grabble.Repository.Interface;

namespace Grabble.Services
{
    public class OrderService : IOrderService
    {
        private IRepository<Order> orderRepository;
        public OrderService(IRepository<Order> orderRepository)
        {
            this.orderRepository = orderRepository;
        }
        public void DeleteOrder(long id)
        {
            throw new NotImplementedException();
        }

        public Order GetOrder(long id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Order> GetOrders()
        {
            return orderRepository.GetAll();
        }

        public void InsertOrder(Order order)
        {
            throw new NotImplementedException();
        }

        public void UpdateOrder(Order order)
        {
            throw new NotImplementedException();
        }
    }
}
