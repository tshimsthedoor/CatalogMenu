using CatalogMenu.Entities;

namespace CatalogMenu.Repositories
{
    public interface IItemsRepository
    {
        Task<Item> GetItemAsync(Guid id);
        //Item GetItem(Guid id, IEnumerable<Item> items);
        Task<IEnumerable<Item>> GetItemsAsync();
        Task CreateItemAsync(Item item);
        Task UpdateItemAsync(Item item);
        Task DeleteItemAsync(Guid id);


    }
}