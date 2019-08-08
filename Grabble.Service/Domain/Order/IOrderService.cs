using Grabble.Data.Domain;
using System.Collections.Generic;

namespace Grabble.Services
{
    public interface IItemService
    {
        IEnumerable<Order> GetOrders();
        Order GetOrder(int id);
        void InsertOrder(Order order);
        void UpdateOrder(Order order);
        void DeleteOrder(int id);

    }
}
