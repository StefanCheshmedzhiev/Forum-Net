using Forum_Net.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Forum_Net.Data.Configurations
{
    public class UsersFollowrsConfiguration : IEntityTypeConfiguration<UserFollower>
    {
        public void Configure(EntityTypeBuilder<UserFollower> userFollower)
        {
            userFollower
                .HasKey(uf => new { uf.UserId, uf.FollowerId });

            userFollower
                .HasOne(uf => uf.User)
                .WithMany(u => u.Followers)
                .HasForeignKey(uf => uf.UserId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Restrict);

            userFollower
                .HasOne(uf => uf.Follower)
                .WithMany()
                .HasForeignKey(uf => uf.FollowerId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Restrict);

            userFollower
                .HasIndex(uf => uf.IsDeleted);
        }
    }
}
