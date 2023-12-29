using Microsoft.EntityFrameworkCore;
using RMK.Domain.Models;
using RMK.Domain.Models.Account;

namespace RMK.Infra.Data
{
    public static class SeedData
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Role>().HasData(
                            new Role
                            {
                                Id = 1,
                                Name = "ادمین",
                                RoleName = "admin_role",
                            },
                            new Role
                            {
                                Id = 2,
                                Name = "کاربر",
                                RoleName = "user_role",
                            });

            modelBuilder.Entity<User>().HasData(
                            new User
                            {
                                Id = 1,
                                UserName = "Saeed",
                                Password = "123",
                                CreateDate = System.DateTime.Now,
                                IsDelete = false,
                                LastUpdateDate = System.DateTime.Now,
                                RoleId = 1
                            },
                            new User
                            {
                                Id = 2,
                                UserName = "Akbari",
                                Password = "123",
                                CreateDate = System.DateTime.Now,
                                IsDelete = false,
                                LastUpdateDate = System.DateTime.Now,
                                RoleId = 1
                            },
                             new User
                             {
                                 Id = 3,
                                 UserName = "Karbar",
                                 Password = "123",
                                 CreateDate = System.DateTime.Now,
                                 IsDelete = false,
                                 LastUpdateDate = System.DateTime.Now,
                                 RoleId = 2
                             });

            modelBuilder.Entity<Person>().HasData(
                            new Person
                            {
                                Id = 1,
                                FullName = "Test1"
                            },
                            new Person
                            {
                                Id = 2,
                                FullName = "Test2"
                            });

            modelBuilder.Entity<Address>().HasData(
                            new Address
                            {
                                Id = 1,
                                City = "Tehran",
                                Street = "Rey",
                                PersonId = 1
                            },
                            new Address
                            {
                                Id = 2,
                                City = "Tehran1",
                                Street = "Rey1",
                                PersonId = 1
                            },
                            new Address
                            {
                                Id = 3,
                                City = "Tehran2",
                                Street = "Rey2",
                                PersonId = 2
                            });
        }
    }
}
