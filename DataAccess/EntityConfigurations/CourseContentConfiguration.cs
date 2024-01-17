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
            builder.ToTable("CourseContents").HasKey(c => c.Id);
            builder.Property(c => c.Id).HasColumnName("Id").IsRequired();
            builder.Property(c => c.CourseId).HasColumnName("CourseId").IsRequired();
            builder.Property(c => c.ContentTypeId).HasColumnName("ContectTypeId").IsRequired(); 
            builder.Property(c => c.Name).HasColumnName("Name").IsRequired();
            //builder.HasMany(c => c.Courses).WithOne(c => c.CourseContent).HasForeignKey(c => c.CourseContentId);
        }
    }
}
