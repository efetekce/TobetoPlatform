﻿using Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.EntityConfigurations
{
    public class SocialMediaPlatformConfiguration:IEntityTypeConfiguration<SocialMediaPlatform>
    {
        public void Configure(EntityTypeBuilder<SocialMediaPlatform> builder)
        {
            builder.ToTable("SocialMediaPlatforms").HasKey(s=>s.Id);
            builder.Property(s=>s.Id).HasColumnName("Id").IsRequired();
            builder.Property(s=>s.Name).HasColumnName("Name").IsRequired();
            builder.Property(s => s.Link).HasColumnName("Link").IsRequired();
            builder.Property(s => s.Priority).HasColumnName("Priority");
            builder.Property(s => s.Visibility).HasColumnName("Visibility");
            builder.HasQueryFilter(e => !e.DeletedDate.HasValue);
        }
    }
}
