using Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.EntityConfigurations
{
    public class CourseDetailConfiguration : IEntityTypeConfiguration<CourseDetail>
    {
        public void Configure(EntityTypeBuilder<CourseDetail> builder)
        {
            builder.ToTable("CourseDetails").HasKey(cd => cd.Id);
            builder.Property(cd => cd.Id).HasColumnName("Id").IsRequired();
            builder.Property(cd => cd.CourseId).HasColumnName("CourseId").IsRequired();
            //builder.Property(cd => cd.CourseContentId).HasColumnName("CourseContentId").IsRequired();
            builder.Property(cd => cd.CategoryId).HasColumnName("CategoryId").IsRequired();
            builder.Property(cd => cd.OrganizationId).HasColumnName("OrganizationId").IsRequired();
            //builder.Property(cd => cd.Language).HasColumnName("Language");
            //builder.Property(cd => cd.SubType).HasColumnName("SubType");
            //builder.HasIndex(indexExpression: cd => cd.CourseId, name: "FK_CourseDetails_Courses");
            //builder.HasIndex(indexExpression: cd => cd.CourseContentId, name: "FK_CourseDetails_CourseContents");
            //builder.HasIndex(indexExpression: cd => cd.CategoryId, name: "FK_CourseDetails_Courses");
            //builder.HasIndex(indexExpression: cd => cd.OrganizationId, name: "FK_CourseDetails_Organizations");

            builder.HasQueryFilter(cd => !cd.DeletedDate.HasValue);
        }
    }
}
