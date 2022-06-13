using MemoryStash.Models;
using System;
using System.Collections.Generic;

namespace MemoryStash.DAL
{
    public interface IItemDal
    {
        
        Item CreateItem(int userId, int containerId, string path, string itemName, DateTime expirationDate, List<ItemTag> tags);
        
        /// <summary>
        /// Deletes an existing Item.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="itemId"></param>
        void DeleteItem(int userId, int itemId);
        
        /// <summary>
        /// Gets an existing Item.
        /// </summary>
        /// <param name="itemID"></param>
        /// <returns></returns>
        Item GetItem(int itemID);
        
        void EditItem(Item item);
        
        /// <summary>
        /// Returns a list of Item objects that match the searched keyword.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="containerId"></param>
        /// <param name="searchKeyword"></param>
        /// <returns></returns>
        List<Item> SearchItem(int userId, int containerId, string searchKeyword);
    }
}