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
    public class CourseConfiguration : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> builder)
        {
            builder.ToTable("Courses").HasKey(c => c.Id);
            builder.Property(c=>c.Id).HasColumnName("Id").IsRequired();
            builder.Property(c => c.CourseContentId).HasColumnName("CourseContentId").IsRequired();
            //builder.Property(c => c.CourseAboutId).HasColumnName("CourseAboutId").IsRequired();
            builder.Property(c => c.LessonId).HasColumnName("LessonId").IsRequired();
            builder.Property(c => c.ImageId).HasColumnName("ImageId");
            builder.Property(c => c.Name).HasColumnName("Name").IsRequired();
            builder.HasMany(c=>c.CourseContents).WithOne(c=>c.Course).HasForeignKey(c=>c.CourseId);
        }
    }
}
