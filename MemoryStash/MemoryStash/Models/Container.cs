using System;
using System.Collections.Generic;

#nullable disable

namespace MemoryStash.Models
{
    public partial class Container
    {
        public Container()
        {
            ContainerTags = new HashSet<ContainerTag>();
            InverseParent = new HashSet<Container>();
            Items = new HashSet<Item>();
        }

        public int Id { get; set; }
        public int UserId { get; set; }
        public int ParentId { get; set; }
        public string Name { get; set; }
        public string Path { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime ModificationDate { get; set; }
        public byte Status { get; set; }

        public virtual Container Parent { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<ContainerTag> ContainerTags { get; set; }
        public virtual ICollection<Container> InverseParent { get; set; }
        public virtual ICollection<Item> Items { get; set; }
    }
}
