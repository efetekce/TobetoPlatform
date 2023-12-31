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
    public class CourseContentTypeConfiguration : IEntityTypeConfiguration<CourseContentType>
    {
        public void Configure(EntityTypeBuilder<CourseContentType> builder)
        {
            builder.ToTable("CourseContentTypes").HasKey(cct => cct.Id);
            builder.Property(cct => cct.Id).HasColumnName("Id").IsRequired();
            builder.Property(cct => cct.Name).HasColumnName("Name").IsRequired();
            builder.HasQueryFilter(cct => !cct.DeletedDate.HasValue);
        }
    }
}
