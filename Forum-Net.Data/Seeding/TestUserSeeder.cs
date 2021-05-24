using System;
using System.Linq;
using System.Threading.Tasks;
using Forum_Net.Common;
using Forum_Net.Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Forum_Net.Data.Seeding
{
    internal class TestUserSeeder : ISeeder
    {
        public async Task SeedAsync(ForumDbContext dbContext, IServiceProvider serviceProvider)
        {
            var userManager = serviceProvider.GetService<UserManager<ForumUser>>();

            var isExisting = await userManager.Users.AnyAsync(u => u.UserName == GlobalConstants.TestUserUserName);
            if (!isExisting)
            {
                var testUser = new ForumUser
                {
                    UserName = GlobalConstants.TestUserUserName,
                    Email = GlobalConstants.TestUserEmail,
                    ProfilePicture = GlobalConstants.TestUserProfilePicture,
                    EmailConfirmed = true
                };

                var result = await userManager.CreateAsync(testUser, GlobalConstants.TestUserPassword);
                if (!result.Succeeded)
                {
                    throw new Exception(string.Join(Environment.NewLine, result.Errors.Select(e => e.Description)));
                }
            }
        }
    }
}

