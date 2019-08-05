using Grabble.Data.Domain;
using System.Collections.Generic;

namespace Grabble.Services
{
    public interface IOrderService
    {
        IEnumerable<Order> GetOrders();
        Order GetUser(int id);
        void InsertOrder(Order order);
        void UpdateOrder(Order order);
        void DeleteOrder(int id);

    }
}
