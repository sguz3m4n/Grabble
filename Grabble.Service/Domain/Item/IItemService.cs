using Grabble.Data.Domain;
using System.Collections.Generic;

namespace Grabble.Services.Domain
{
    public interface IItemService
    {
        IEnumerable<Item> GetItems();
        Item GetItem(int id);
        void InsertItem(Item item);
        void UpdateItem(Item item);
        void DeleteItem(int id);
    }
}
