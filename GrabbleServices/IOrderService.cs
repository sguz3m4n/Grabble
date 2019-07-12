using Grabble.Data.Domain.Order;
using System;
using System.Collections.Generic;

namespace Grabble.Services
{
    public interface IOrderService
    {
        IEnumerable<Order> GetOrders();
        List<Order> GetListOrders();
        Order GetOrder(long id);
        void InsertOrder(Order order);
        void UpdateOrder(Order order);
        void DeleteOrder(long id);
    }
}
