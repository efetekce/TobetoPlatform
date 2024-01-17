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
            builder.ToTable("CourseDetails").HasKey(c => c.Id);
            builder.Property(c => c.CourseId).HasColumnName("CourseId").IsRequired();
            builder.Property(c => c.CourseContentId).HasColumnName("CourseContentId").IsRequired();
            builder.Property(c => c.CategoryId).HasColumnName("CategoryId").IsRequired();
            builder.Property(c => c.OrganizationId).HasColumnName("OrganizationId").IsRequired();
            builder.Property(c => c.ForeignLanguageId).HasColumnName("ForeignLanguageId").IsRequired();
            builder.Property(c => c.SubType).HasColumnName("SubType").IsRequired();

            builder.HasOne(c => c.Course).WithOne(c => c.CourseDetail).HasForeignKey<CourseDetail>(c => c.CourseId);
            //builder.HasOne(c => c.CourseDetail).WithMany(c => c.CourseContent).HasForeignKey(c => c.CourseContentId);
        }
    }
}
