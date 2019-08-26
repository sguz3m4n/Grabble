using System;
using System.Collections.Generic;
using System.Text;
using Grabble.Data.Domain;
using Grabble.Repository.Interface;

namespace Grabble.Service.Domain.Inventory
{
    public class StockServices : IStockService
    {
        private IRepository<Stock> stockRespository;
        public StockServices(IRepository<Stock> stockrepository)
        {
            this.stockRespository = stockrepository;
        }
        public void DeleteStock(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Stock> GetStock()
        {
            return stockRespository.GetAll();
        }

        public Stock GetStock(int id)
        {
            return stockRespository.Get(id);
        }

        public void InsertStock(Stock stock)
        {
            stockRespository.Insert(stock);
        }

        public void UpdateStock(Stock stock)
        {
            stockRespository.Update(stock);
        }
    }
}
