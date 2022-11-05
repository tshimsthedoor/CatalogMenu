using CatalogMenu.Entities;

namespace CatalogMenu.Repositories
{
    public interface IItemsRepository
    {
        Item GetItem(Guid id);
        //Item GetItem(Guid id, IEnumerable<Item> items);
        IEnumerable<Item> GetItems();
        void CreateItem(Item item);
        void UpdateItem(Item item);
        void DeleteItem(Guid id);


    }
}