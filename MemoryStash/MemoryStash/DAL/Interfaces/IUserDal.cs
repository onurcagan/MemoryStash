using MemoryStash.Models;

namespace MemoryStash.DAL
{
    public interface IUserDal
    {
        /// <summary>
        /// Used for Loggin in.
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        User GetUser(string username, string password);

        /// <summary>
        /// Used to change password.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="NewPassword"></param>
        void ChangePassword(int userId, string currentPassword,string newPassword);

        /// <summary>
        /// Used to deactivate an account.
        /// </summary>
        /// <param name="UserId"></param>
        void DeactivateUser(int userId, string password);

        /// <summary>
        /// Used to register a new account.
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <param name="fullname"></param>
        /// <returns></returns>
        void Register(string username, string password, string fullname);
    }
}