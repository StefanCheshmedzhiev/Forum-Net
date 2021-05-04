using Forum_Net.Common;
using Forum_Net.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Forum_Net.Data.Configurations
{
    public class MessageConfiguration : IEntityTypeConfiguration<Message>
    {
        public void Configure(EntityTypeBuilder<Message> message)
        {
            message
                .Property(m => m.Content)
                .HasMaxLength(GlobalConstants.MessageContentMaxLength)
                .IsRequired();

            message
                .HasOne(m => m.Author)
                .WithMany(a => a.SentMessages)
                .HasForeignKey(m => m.AuthorId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Restrict);

            message
                .HasOne(m => m.Receiver)
                .WithMany(a => a.ReceivedMessages)
                .HasForeignKey(m => m.ReceiverId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Restrict);

            message
                .HasIndex(m => m.IsDeleted);
        }
    }
}
