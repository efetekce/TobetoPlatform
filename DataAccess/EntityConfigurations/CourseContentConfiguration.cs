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
    public class CourseContentConfiguration : IEntityTypeConfiguration<CourseContent>
    {
        public void Configure(EntityTypeBuilder<CourseContent> builder)
        {
            builder.ToTable("CourseContents").HasKey(cc => cc.Id);
            builder.Property(cc => cc.Id).HasColumnName("Id").IsRequired();
            builder.Property(cc => cc.CourseId).HasColumnName("CourseId").IsRequired();
            builder.Property(cc => cc.ContentTypeId).HasColumnName("ContectTypeId").IsRequired(); 
            builder.Property(cc => cc.Name).HasColumnName("Name").IsRequired();
            builder.HasQueryFilter(cc => !cc.DeletedDate.HasValue);
            builder.HasMany(cc => cc.Courses).WithOne(cc => cc.CourseContent).HasForeignKey(cc => cc.CourseContentId);
        }
    }
}
