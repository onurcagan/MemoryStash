using System;
using System.Collections.Generic;

#nullable disable

namespace MemoryStash.Models
{
    public partial class User
    {
        public User()
        {
            Containers = new HashSet<Container>();
            Items = new HashSet<Item>();
        }

        public int Id { get; set; }
        public string Username { get; set; }
        public string PasswordHash { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime ModificationDate { get; set; }
        public byte Status { get; set; }

        public virtual ICollection<Container> Containers { get; set; }
        public virtual ICollection<Item> Items { get; set; }
    }
}
