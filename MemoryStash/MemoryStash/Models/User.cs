using System;
using System.Collections.Generic;

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
        public string UserName { get; set; }
        public string FullName { get; set; }
        public string PasswordHash { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime ModificationDate { get; set; }
        public bool Status { get; set; }

        public virtual ICollection<Container> Containers { get; set; }
        public virtual ICollection<Item> Items { get; set; }
    }
}
