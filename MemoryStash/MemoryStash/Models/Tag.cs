using System;
using System.Collections.Generic;

namespace MemoryStash.Models
{
    public partial class Tag
    {
        public Tag()
        {
            ContainerTags = new HashSet<ContainerTag>();
            ItemTags = new HashSet<ItemTag>();
        }

        public int Id { get; set; }
        public string TagName { get; set; }

        public virtual ICollection<ContainerTag> ContainerTags { get; set; }
        public virtual ICollection<ItemTag> ItemTags { get; set; }
    }
}
