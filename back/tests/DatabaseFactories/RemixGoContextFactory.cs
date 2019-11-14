using domain;
using domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;

namespace tests.DatabaseFactories
{
    public static class RemixGoContextFactory
    {
        public static RemixGoContext GetContext() =>
            new RemixGoContext(
                new DbContextOptionsBuilder<RemixGoContext>()
                    .UseInMemoryDatabase($"remixgo{new Random().Next()}")
                    .Options
            );

        public static RemixGoContext ApplyUserMocks(this RemixGoContext context)
        {
            context.Users.AddRange(
                new User
                {
                    Username = "fulano",
                    Fullname = "fulano de sicrano",
                    Email = "fulano@email.com",
                    Password = "fu1@n0",
                },
                new User
                {
                    Username = "beltrano",
                    Fullname = "beltrano de sicrano",
                    Email = "beltrano@email.com",
                    Password = "b31tr@n0"
                }
            );
            context.SaveChanges();

            return context;
        }
    }
}