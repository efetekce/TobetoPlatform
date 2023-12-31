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
    public class DistrictConfiguration:IEntityTypeConfiguration<District>
    {
        public void Configure(EntityTypeBuilder<District> builder)
        {
            builder.ToTable("Districts").HasKey(d => d.Id);
            builder.Property(d => d.Id).HasColumnName("Id").IsRequired();
            builder.Property(d => d.CityId).HasColumnName("CityId").IsRequired();
            builder.Property(d => d.Name).HasColumnName("Name");
            builder.Property(d => d.Priority).HasColumnName("Priority");
            builder.Property(d => d.Visibility).HasColumnName("Visibility");

            // Relationship
            builder
                .HasOne(d => d.City)
                .WithMany(c => c.Districts)
                .HasForeignKey(d => d.CityId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
