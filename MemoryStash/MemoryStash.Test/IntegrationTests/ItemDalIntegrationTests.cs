using MemoryStash.DAL;
using MemoryStash.Models;
using System;
using System.Collections.Generic;
using Xunit;

namespace MemoryStash.Test
{
    [Trait("Category", "Integration")]
    public class ItemDalIntegrationTests
    {
        [Fact]
        public void CreateItemTest()
        {
            //Arrange
            ItemDal itemDal = new ItemDal();
            DateTime expirationDate = new DateTime(2022, 10, 10);
            List<ItemTag> itemTags = new();


            //Act
            Item item = itemDal.CreateItem(1, 1, "SomeContainer/Banana", "Banana", expirationDate, itemTags);


            //Assert
            Assert.NotNull(item);
        }

        [Fact]
        public void DeleteItemTest()
        {
            //Arrange
            using MemoryStashContext msc = new();
            ItemDal itemDal = new();
            Item item = msc.Items.Find(9);

            //Act
            itemDal.DeleteItem(1, 9);

            //Assert
            Assert.False(item.Status);
        }

        [Fact]
        public void EditItemTest()
        {
            //Arrange
            ItemDal itemDal = new ItemDal();
            Item item = new()
            {
                Id = 10,
                UserId = 1,
                ContainerId = 1,
                Name = "PepeLaugh",
                Path = "SomeContainer/"
            };


            //Act
            itemDal.EditItem(item);

            //Assert
            Assert.Equal(item.Name, item.Name);
        }

        [Fact]
        public void GetItemTest()
        {
            //Arrange
            ItemDal itemDal = new ItemDal();


            //Act
            Item item = itemDal.GetItem(10);

            //Assert
            Assert.Equal(10, item.Id);
        }

        [Fact]
        public void SearchItemTest()
        {
            //Arrange
            ItemDal itemDal = new ItemDal();


            //Act

            //Assert

        }

    }
}
