using MemoryStash.Models;
using System;
using System.Collections.Generic;

namespace MemoryStash.DAL
{
    public class ItemDal : IItemDal
    {
        public Item CreateItem(int userId, int containerId, string path, string itemName, DateTime expirationDate, List<ItemTag> tags)
        {
            using MemoryStashContext msc = new();

            User user = msc.Users.Find(userId);

            if (user == null)
            {
                throw new KeyNotFoundException();
            }
                        
            DateTime dateTime = DateTime.Now;

            Item item = new()
            {
                UserId = userId,
                ContainerId = containerId,
                Name = itemName,
                Path = path,
                ExpirationDate = expirationDate,
                CreationDate = dateTime,
                ModificationDate = dateTime,
                ItemTags = tags,
                Status = true
            };

            msc.Items.Add(item);

            msc.SaveChanges();

            return item;
        }

        public void DeleteItem(int userId, int itemId)
        {
            using MemoryStashContext msc = new();

            Item item = msc.Items.Find(itemId);

            if (item == null)
            {
                throw new KeyNotFoundException();
            }

            if (item.UserId != userId)
            {
                throw new UnauthorizedAccessException();
            }

            item.Status = false;

            msc.SaveChanges();
        }

        public void EditItem(Item item)
        {
            using MemoryStashContext msc = new();

            msc.Items.Update(item);

            msc.SaveChanges();

        }

        public Item GetItem(int itemId)
        {
            using MemoryStashContext msc = new();

            Item item = msc.Items.Find(itemId);

            if (item == null)
            {
                throw new KeyNotFoundException();
            }

            return item;
        }

        public List<Item> SearchItem(int userId, int containerId, string searchKeyword)
        {
            using MemoryStashContext msc = new();

            List<Item> item = new();

            return item;
        }
    }
}
