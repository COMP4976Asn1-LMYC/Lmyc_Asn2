using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using LmycWeb.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace LmycWeb.Data
{
    public class DummyData
    {
        public static async Task Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ApplicationDbContext(
                serviceProvider.GetRequiredService<DbContextOptions<ApplicationDbContext>>()))
            {
                var admin = new ApplicationUser
                {
                    UserName = "a",
                    Email = "a@a.a",
                    FirstName = "Ben",
                    LastName = "How",
                    EmailConfirmed = true,
                    MobileNumber = "7780000000",
                    Street = "1st St.",
                    City = "Burnaby",
                    Province = "BC",
                    PostalCode = "A1A A1A",
                    Country = "Canada",
                    SailingExperience = 100,
                };

                var adminId = await SeedingUser(serviceProvider, admin, "P@$$w0rd");

                await SeedingRole(serviceProvider, adminId, "Admin");

                var member = new ApplicationUser
                {
                    UserName = "m",
                    Email = "m@m.m",
                    FirstName = "Benjamin",
                    LastName = "Hao",
                    EmailConfirmed = true,
                    MobileNumber = "7780000001",
                    Street = "2nd St.",
                    City = "Burnaby",
                    Province = "BC",
                    PostalCode = "B2B B2B",
                    Country = "Canada",
                    SailingExperience = 0,
                };

                var memberId = await SeedingUser(serviceProvider, member, "P@$$w0rd");

                await SeedingRole(serviceProvider, memberId, "Member");

                if (context.Boats.Any())
                {
                    return;
                }

                foreach (var boat in GetBoats(adminId))
                {
                    context.Boats.Add(boat);
                }

                context.SaveChanges();
            }
        }

        private static async Task<string> SeedingUser(IServiceProvider serviceProvider, ApplicationUser newUser, string password)
        {
            var userManager = serviceProvider.GetService<UserManager<ApplicationUser>>();
            var user = await userManager.FindByNameAsync(newUser.UserName);

            if (user == null)
            {
                user = new ApplicationUser
                {
                    UserName = newUser.UserName,
                    Email = newUser.Email,
                    FirstName = newUser.FirstName,
                    LastName = newUser.LastName,
                    Street = newUser.Street,
                    City = newUser.City,
                    Province = newUser.Province,
                    PostalCode = newUser.PostalCode,
                    Country = newUser.Country,
                    MobileNumber = newUser.MobileNumber,
                    SailingExperience = newUser.SailingExperience
                };

                await userManager.CreateAsync(user, password);
            }
            return user.Id;
        }


        public static async Task<IdentityResult> SeedingRole(IServiceProvider serviceProvider, string uid, string role)
        {
            IdentityResult result = null;
            var roleManager = serviceProvider.GetService<RoleManager<IdentityRole>>();

            if (!await roleManager.RoleExistsAsync(role))
            {
                result = await roleManager.CreateAsync(new IdentityRole(role));
            }

            var userManager = serviceProvider.GetService<UserManager<ApplicationUser>>();
            var user = await userManager.FindByIdAsync(uid);

            result = await userManager.AddToRoleAsync(user, role);

            return result;
        }

        private static List<Boat> GetBoats(string adminId)
        {
            List<Boat> Boats = new List<Boat>()
            {
                new Boat()
                {
                    BoatName = "Marquis 420 Sport Coupe",
                    Picture = "http://images.boats.com/resize/1/87/46/6298746_20170713143815495_1_LARGE.jpg?w=900&h=900",
                    LengthInFeet = 41.99,
                    Make = "Marquis",
                    Year = 2011,
                    CreationDate = new DateTime(2018,1,1),
                    CreatedBy = adminId
                },

                                new Boat()
                {
                    BoatName = "Wendon Sky Lounge",
                    Picture = "http://images.boats.com/resize/1/87/46/6298746_20170713143815495_1_LARGE.jpg?w=900&h=900",
                    LengthInFeet = 72.99,
                    Make = "Wendon",
                    Year = 2004,
                    CreationDate = new DateTime(2018,1,2),
                    CreatedBy = adminId
                },

                                               new Boat()
                {
                    BoatName = "Bavaria Cruiser 46",
                    Picture = "http://images.boats.com/resize/1/87/46/6298746_20170713143815495_1_LARGE.jpg?w=900&h=900",
                    LengthInFeet = 45.99,
                    Make = "Bavaria",
                    Year = 2018,
                    CreationDate = new DateTime(2018,1,3),
                    CreatedBy = adminId
                },

            };
            return Boats;
        }
    }
}