using System;
using System.Collections.Generic;

namespace MemoryStash.Models
{
    public partial class ContainerTag
    {
        public int Id { get; set; }
        public int? ContainerId { get; set; }
        public int? TagId { get; set; }

        public virtual Container Container { get; set; }
        public virtual Tag Tag { get; set; }
    }
}
