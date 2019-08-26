using Grabble.Data.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Grabble.Service.Domain.Inventory
{
 public   interface IStockService
    {
        IEnumerable<Stock> GetStock();
        Stock GetStock(int id);
        void InsertStock(Stock stock);
        void UpdateStock(Stock stock);
        void DeleteStock(int id);
    }
}
