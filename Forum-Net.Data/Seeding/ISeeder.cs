using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Forum_Net.Data.Seeding
{
    public interface ISeeder
    {
        Task SeedAsync(ForumDbContext dbContext, IServiceProvider serviceProvider);
    }
}
