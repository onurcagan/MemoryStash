using MemoryStash.Models;
using System.Collections.Generic;

namespace MemoryStash.DAL
{
    public interface IContainerDal
    {
        /// <summary>
        /// Creates a new container.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="containerName"></param>
        /// <param name="parentId"></param>
        /// <param name="tags"></param>
        int CreateContainer(int userId, string containerName, int parentId, List<ContainerTag> tags);

        /// <summary>
        /// Deletes an existing Container.
        /// </summary>
        /// <param name="UserId"></param>
        /// <param name="ContainerId"></param>
        void DeleteContainer(int UserId, int ContainerId);

       
        Container GetContainer(int userId,int ContainerId);

        /// <summary>
        /// Edits an existing Container.
        /// </summary>
        /// <param name="container"></param>
        void EditContainer(Container container);

        
        List<Container> SearchContainer(int UserId, string containerName);

        List<Container> ListAllChildren(int userId, int containerId);
    }
}