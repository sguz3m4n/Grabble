using Grabble.Data.Domain.Order;

namespace Grabble.Services
{
    public interface IOrderService
    {
        //IEnumberable<Order> GetOrders();
        Order GetUser(int id);
        void InsertOrder(Order order);
        void UpdateOrder(Order order);
        void DeleteOrder(int id);

    }
}
