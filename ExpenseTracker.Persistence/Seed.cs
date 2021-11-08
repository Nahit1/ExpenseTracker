using ExpenseTracker.Domain;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseTracker.Persistence
{
    public class Seed
    {
        public static async Task SeedData(DataContext context,
            UserManager<AppUser> userManager)
        {
            if (!userManager.Users.Any())
            {
                var users = new List<AppUser>
                {
                    new AppUser
                    {
                        Name = "Nahit",
                        Surname = "Ektaş",
                        UserName = "nahit",
                        Email = "nahit@test.com"
                    },
                    new AppUser
                    {
                        Name="Ferhat",
                        Surname="Ektaş",
                        UserName = "ferhat",
                        Email = "ferhat@test.com"
                    },
                };

                foreach (var user in users)
                {
                    await userManager.CreateAsync(user, "Pa$$w0rd");
                }
                await context.SaveChangesAsync();
            }
        }
    }
}
