﻿using Entities.Concretes;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.EntityConfigurations
{
    public class CountryConfiguration : IEntityTypeConfiguration<Country>
    {
        public void Configure(EntityTypeBuilder<Country> builder)
        {
            builder.ToTable("Countries").HasKey(c => c.Id);
            builder.Property(c => c.Id).HasColumnName("Id").IsRequired();
            builder.Property(c => c.Name).HasColumnName("Name");
            builder.Property(c => c.Priority).HasColumnName("Priority");
            builder.Property(c => c.Visibility).HasColumnName("Visibility");
            builder.HasQueryFilter(c => !c.DeletedDate.HasValue);
        }
    }
}
