using System;
using System.Collections.Generic;

#nullable disable

namespace MemoryStash.Models
{
    public partial class ContainerTag
    {
        public int Id { get; set; }
        public int TagId { get; set; }
        public int ContainerId { get; set; }

        public virtual Container Container { get; set; }
        public virtual Tag Tag { get; set; }
    }
}
