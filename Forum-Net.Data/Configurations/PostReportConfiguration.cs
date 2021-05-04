﻿using Forum_Net.Common;
using Forum_Net.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Forum_Net.Data.Configurations
{
    public class PostReportConfiguration : IEntityTypeConfiguration<PostReport>
    {
        public void Configure(EntityTypeBuilder<PostReport> postReport)
        {
            postReport
                .Property(r => r.Description)
                .HasMaxLength(GlobalConstants.PostReportDescriptionMaxLength)
                .IsRequired();

            postReport
                .HasOne(pr => pr.Author)
                .WithMany(a => a.PostReports)
                .HasForeignKey(pr => pr.AuthorId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Restrict);

            postReport
                .HasOne(pr => pr.Post)
                .WithMany(p => p.Reports)
                .HasForeignKey(pr => pr.PostId)
                .OnDelete(DeleteBehavior.Restrict);

            postReport
                 .HasIndex(pr => pr.IsDeleted);
        }
    }
}
