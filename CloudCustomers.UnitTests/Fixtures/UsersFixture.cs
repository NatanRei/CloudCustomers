using CloudCustomers.API.Models;

namespace CloudCustomers.UnitTests.Fixtures
{
    public static class UsersFixture
    {
        public static List<User> GetTestUsers() => new()
        {
            new User {
                Id = 1,
                Name = "Natan",
                Email = "test@test.com",
                Address = new Address() {
                        City = "Curitiba",
                        Street = "Mario Tourinho",
                        ZipCode = "80020100"
                    },
                },
            new User {
                Id = 1,
                Name = "Reis",
                Email = "reis@test.com",
                Address = new Address() {
                        City = "Paraná",
                        Street = "Tiradentes",
                        ZipCode = "80020100"
                    }
                },

        };
    }
}
