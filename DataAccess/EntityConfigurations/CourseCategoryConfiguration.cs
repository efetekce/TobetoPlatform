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
    public class CourseCategoryConfiguration : IEntityTypeConfiguration<CourseCategory>
    {
        public void Configure(EntityTypeBuilder<CourseCategory> builder)
        {
            builder.ToTable("CourseCategories").HasKey(cc => cc.Id);
            builder.Property(cc => cc.Id).HasColumnName("Id").IsRequired();
            builder.Property(cc => cc.Name).HasColumnName("Name").IsRequired();
            builder.HasQueryFilter(cc => !cc.DeletedDate.HasValue);
        }
    }
}
