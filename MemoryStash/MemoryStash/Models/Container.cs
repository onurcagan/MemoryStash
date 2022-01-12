using System;
using System.Collections.Generic;

namespace MemoryStash.Models
{
    public partial class Container
    {
        public Container()
        {
            ContainerTags = new HashSet<ContainerTag>();
            Items = new HashSet<Item>();
        }

        public int Id { get; set; }
        public int UserId { get; set; }
        public int? ParentId { get; set; }
        public string Name { get; set; }
        public string Path { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime ModificationDate { get; set; }
        public bool Status { get; set; }

        public virtual User User { get; set; }
        public virtual ICollection<ContainerTag> ContainerTags { get; set; }
        public virtual ICollection<Item> Items { get; set; }
    }
}
