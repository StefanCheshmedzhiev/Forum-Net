using Forum_Net.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Forum_Net.Data.Configurations
{
    public class PostReactionConfiguration : IEntityTypeConfiguration<PostReaction>
    {
        public void Configure(EntityTypeBuilder<PostReaction> postReaction)
        {
            postReaction
                .HasOne(pr => pr.Post)
                .WithMany(p => p.Reactions)
                .HasForeignKey(pr => pr.PostId)
                .OnDelete(DeleteBehavior.Restrict);

            postReaction
                .HasOne(pr => pr.Author)
                .WithMany(p => p.PostReactions)
                .HasForeignKey(pr => pr.AuthorId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
