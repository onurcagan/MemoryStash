using System;
using System.Collections.Generic;

#nullable disable

namespace MemoryStash.Models
{
    public partial class Item
    {
        public Item()
        {
            ItemTags = new HashSet<ItemTag>();
        }

        public int Id { get; set; }
        public int UserId { get; set; }
        public int ContainerId { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public string Path { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime ModificationDate { get; set; }
        public byte Status { get; set; }

        public virtual Container Container { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<ItemTag> ItemTags { get; set; }
    }
}
