using Forum_Net.Common;
using Forum_Net.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Forum_Net.Data.Configurations
{
    public class IdentityUserConfiguration : IEntityTypeConfiguration<ForumUser>
    {
        public void Configure(EntityTypeBuilder<ForumUser> user)
        {
            user
                .Property(u => u.ProfilePicture)
                .IsRequired();

            user
                .Property(u => u.Biography)
                .HasMaxLength(GlobalConstants.UserBiographyMaxLength);

            user
                .HasMany(e => e.Claims)
                .WithOne()
                .HasForeignKey(e => e.UserId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Restrict);

            user
                .HasMany(e => e.Logins)
                .WithOne()
                .HasForeignKey(e => e.UserId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Restrict);

            user
                .HasMany(e => e.Roles)
                .WithOne()
                .HasForeignKey(e => e.UserId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Restrict);

            user
                .HasIndex(u => u.IsDeleted);
        }
    }
}
