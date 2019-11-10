using Grabble.Data.Domain;
using System.Collections.Generic;

namespace Grabble.Services
{
    public interface IConsumerService
    {
        IEnumerable<Consumer> GetConsumers();
        Consumer GetConsumer(int id);
        void InsertConsumer(Consumer consumer);
        void UpdateConsumer(Consumer consumer);
        void DeleteConsumer(int id);

    }
}
