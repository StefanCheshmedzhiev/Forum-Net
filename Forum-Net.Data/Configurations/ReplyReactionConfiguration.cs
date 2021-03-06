using Forum_Net.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Forum_Net.Data.Configurations
{
    public class ReplyReactionConfiguration : IEntityTypeConfiguration<ReplyReaction>
    {
        public void Configure(EntityTypeBuilder<ReplyReaction> replyReaction)
        {
            replyReaction
                .HasOne(rr => rr.Reply)
                .WithMany(r => r.Reactions)
                .HasForeignKey(rr => rr.ReplyId)
                .OnDelete(DeleteBehavior.Restrict);

            replyReaction
                .HasOne(rr => rr.Author)
                .WithMany(r => r.ReplyReactions)
                .HasForeignKey(rr => rr.AuthorId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
