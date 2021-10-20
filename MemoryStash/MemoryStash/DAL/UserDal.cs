using MemoryStash.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MemoryStash.DAL
{
    public class UserDal : IUserDal
    {
        public User GetUser(string username, string password)
        {
            using MemoryStashContext msc = new();

            User user = msc.Users.FirstOrDefault(u => u.Username == username && u.PasswordHash == password);

            return user;
        }
    }
}
