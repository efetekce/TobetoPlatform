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
    public class AccountSocialMediaConfiguration : IEntityTypeConfiguration<AccountSocialMedia>
    {
        public void Configure(EntityTypeBuilder<AccountSocialMedia> builder)
        {
            builder.ToTable("AccountSocialMedias").HasKey(a => a.Id);
            builder.Property(a => a.Id).HasColumnName("Id").IsRequired();
            builder.Property(a => a.AccountId).HasColumnName("AccountId").IsRequired();
            builder.Property(a => a.SocialMediaId).HasColumnName("SocialMediaId").IsRequired();
            builder.Property(a => a.Link).HasColumnName("Link").IsRequired();
            builder.Property(a => a.Priority).HasColumnName("Priority");
            builder.HasQueryFilter(e => !e.DeletedDate.HasValue);

           // builder.HasKey(a => a.Account);
        }
    }
}
