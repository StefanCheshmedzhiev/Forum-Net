using Forum_Net.Common;
using Forum_Net.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Forum_Net.Data.Configurations
{
    public class TagConfiguration : IEntityTypeConfiguration<Tag>
    {
        public void Configure(EntityTypeBuilder<Tag> tag)
        {
            tag
                .Property(t => t.Name)
                .HasMaxLength(GlobalConstants.TagNameMaxLength)
                .IsRequired();

            tag
                .HasIndex(t => t.IsDeleted);
        }
    }
}
