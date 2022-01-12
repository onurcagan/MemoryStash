using MemoryStash.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MemoryStash.DAL
{
    public class UserDal : IUserDal
    {
        public void ChangePassword(int userId, string currentPassword, string newPassword)
        {
            using MemoryStashContext msc = new();

            User user = msc.Users.Find(userId);

            if (user == null)
            {
                throw new KeyNotFoundException();
            }

            if (currentPassword != user.PasswordHash)
            {
                throw new UnauthorizedAccessException();
            }

            user.PasswordHash = newPassword;

            msc.SaveChanges();
        }

        public void DeactivateUser(int userId, string password)
        {
            using MemoryStashContext msc = new();

            User user = msc.Users.Find(userId);

            if (user == null)
            {
                throw new KeyNotFoundException();
            }

            if (password != user.PasswordHash)
            {
                throw new UnauthorizedAccessException();
            }

            user.Status = false;

            msc.SaveChanges();
        }

        public User GetUser(string username, string password)
        {
            using MemoryStashContext msc = new();

            User user = msc.Users.FirstOrDefault(u => u.UserName == username && u.PasswordHash == password);

            return user;
        }

        public void Register(string username, string password, string fullname)
        {
            using MemoryStashContext msc = new();

            DateTime dateTime = DateTime.Now;

            msc.Users.Add(new User
            {
                UserName = username,
                PasswordHash = password,
                FullName = fullname,
                CreationDate = dateTime,
                ModificationDate = dateTime,
                Status = true
            });

            msc.SaveChanges();
        }
    }
}
