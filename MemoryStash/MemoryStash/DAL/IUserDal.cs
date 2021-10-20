using MemoryStash.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MemoryStash.DAL
{
    public interface IUserDal
    {
        User GetUser(string username, string password);
    }
}
