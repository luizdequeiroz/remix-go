using domain.Entities;
using repository;
using service;
using service.Interfaces;
using System;
using System.Linq;
using tests.DatabaseFactories;
using Xunit;

namespace tests.ServiceTests
{
    public class UserServiceTest
    {
        private readonly IUserService userService;

        public UserServiceTest()
        {
            userService = new UserService
            (
                new GenericRepository<User>
                (
                    RemixGoContextFactory
                        .GetContext()
                        .ApplyUserMocks()
                ), null, null
            );
        }

        [Theory(DisplayName = "Teste de captura de usuário por Id.")]
        [InlineData(1)]
        [InlineData(3)]
        [InlineData(0)]
        [InlineData(-1)]
        public void GetUserByIdTest(int id)
        {
            var user = userService.GetByIdAsync(id).Result;

            if (user != null)
            {
                Assert.True(user.Id > 0);
                Assert.False(string.IsNullOrEmpty(user.Username));
            }
        }

        [Fact(DisplayName = "Teste de inserção de usuário novo.")]
        public void SetNewUserTest()
        {
            var userCreated = userService.SetNewAsync(new User
            {
                Username = "sicrano",
                Fullname = "sicrano silva",
                Email = "sicrano@email.com",
                Password = "s1cr@n0"
            }).Result;

            if (userCreated != null)
            {
                Assert.True(userCreated.Id > 0);
                Assert.Equal(DateTime.Now.Day, userCreated.RegisterDate.Day);
                Assert.Null(userCreated.UpdateDate);
                Assert.False(string.IsNullOrEmpty(userCreated.Username));
            }
        }

        [Fact(DisplayName = "Teste de atualização de usuário.")]
        public void AlterUserTest()
        {
            var firstUserId = userService.GetAllAsync().Result.First().Id;
            var originalFullnameUser = userService.GetByIdAsync(firstUserId).Result?.Fullname;
            var userUpdated = userService.AlterAsync(new User
            {
                Id = firstUserId,
                Fullname = "beltrano de sicrano silva"
            }).Result;

            if (userUpdated != null)
            {
                Assert.True(userUpdated.Id > 0);
                Assert.True(userUpdated.UpdateDate.Value.Day == DateTime.Now.Day);
                Assert.NotEqual(originalFullnameUser, userUpdated.Fullname);
                Assert.True(userUpdated.Fullname.Length > originalFullnameUser.Length);
                Assert.False(string.IsNullOrEmpty(userUpdated.Username));
            }
        }

        [Fact(DisplayName = "Teste de captura de todos os usuários.")]
        public void GetAllUsersTest()
        {
            var users = userService.GetAllAsync().Result;

            Assert.True(users.Count > 0);
        }

        [Theory(DisplayName = "Teste de deleção de usuário.")]
        [InlineData(1)]
        [InlineData(3)]
        [InlineData(0)]
        [InlineData(-1)]
        public void DeleteUserTest(int id)
        {
            var usersCount = userService.GetAllAsync().Result.Count;
            var deleted = userService.DeleteAsync(id).Result;

            var users = userService.GetAllAsync().Result;

            if (deleted)
                Assert.Equal(2, users.First().Id);
            else Assert.Equal(usersCount, users.Count);
        }
    }
}
