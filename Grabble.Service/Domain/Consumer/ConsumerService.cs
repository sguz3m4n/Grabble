using Grabble.Data.Domain;
using Grabble.Repository.Interface;
using System;
using System.Collections.Generic;

namespace Grabble.Services
{
    public class ConsumerService : IConsumerService
    {

        private IRepository<Consumer> consumerRespository;

        public ConsumerService(IRepository<Consumer> consumerrepository)
        {
            this.consumerRespository = consumerrepository;
        }

        public void DeleteConsumer(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Consumer> GetConsumers()
        {
            return consumerRespository.GetAll();
        }

        public Consumer GetConsumer(int id)
        {
            return consumerRespository.Get(id);
        }

        public void InsertConsumer(Consumer consumer)
        {
            consumerRespository.Insert(consumer);
        }

        public void UpdateConsumer(Consumer consumer)
        {
            consumerRespository.Update(consumer);
        }
    }
}
