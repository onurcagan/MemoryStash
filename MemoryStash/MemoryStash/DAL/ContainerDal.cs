using MemoryStash.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

//namespace MemoryStash.DAL
//{
//    public class ContainerDal : IContainerDal
//    {
//        public void CreateContainer(int UserId, string ContainerName)
//        {
//            // no clue how to create a new db entry :/
//        }

//        public void DeleteContainer(int UserId, int ContainerId)
//        {
//            // dunno the method to delete a db item either :/
//            // change status, don't delete it from db.

//        }

//        public void EditContainer(int UserId, string ContainerName, string NewContainerName)
//        {
//            using MemoryStashContext msc = new();

//            Container container = msc.Containers.FirstOrDefault(u => u.UserId == UserId && u.Name == ContainerName);

//            container.Name = NewContainerName;

//            return;
//        }

//        //Should we also include UserId here as a parameter?
//        public Container GetContainer(int ContainerId)
//        {
//            using MemoryStashContext msc = new();

//            Container container = msc.Containers.FirstOrDefault(u => u.Id == ContainerId);

//            return container;
//        }

//        public List<Container> SearchContainer(int UserId, int ContainerID)
//        {
//            using MemoryStashContext msc = new();

//            // uhm, what do?
//            List<Container> listOfContainers;

//            return listOfContainers;
//        }
//    }
//}
