using MemoryStash.DAL;
using MemoryStash.Models;
using Xunit;

namespace MemoryStash.Test
{
    [Trait("Category", "Integration")]
    public class UserDALIntegrationTest
    {
        [Fact]
        public void ChangePasswordTest()
        {
            //Arrange
            UserDal userDal = new UserDal();
            string newPassword = "enterSomethingToTest";
            string currentPassword = "someRandomPassword";

            //Act
            userDal.ChangePassword(5, currentPassword, newPassword);
            User user = userDal.GetUser("pelinkun", newPassword);

            //Assert
            Assert.True(user.PasswordHash == newPassword);
        }

        [Fact]
        public void DeactivateUserTest()
        {
            //Arrange
            UserDal userDal = new UserDal();

            //Act
            userDal.DeactivateUser(5, "someRandomPassword");
            User user = userDal.GetUser("pelinkun", "someRandomPassword");

            //Assert
            Assert.False(user.Status);
        }

        [Fact]
        public void RegisterAndGetUserTest()
        {
            //Arrange
            UserDal userDal = new UserDal();


            //Act
            userDal.Register("onur", "kekwIsMyPassword", "Onur Cagan");
            User user = userDal.GetUser("onur", "kekwIsMyPassword");

            //Assert
            Assert.NotNull(user);
        }
    }
}