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
    public class LessonConfiguration : IEntityTypeConfiguration<Lesson>
    {
        public void Configure(EntityTypeBuilder<Lesson> builder)
        {
            builder.ToTable("Lessons").HasKey(l => l.Id);
            builder.Property(l => l.Id).HasColumnName("Id").IsRequired();
            builder.Property(l => l.CourseId).HasColumnName("CourseId").IsRequired();
            builder.Property(l => l.CourseContentId).HasColumnName("CourseContentId").IsRequired();
            builder.Property(l => l.Name).HasColumnName("Name");
            builder.Property(l => l.VideoDuration).HasColumnName("VideoDuration");
            builder.HasIndex(indexExpression: l => l.CourseId, name: "FK_Lessons_Courses");
            builder.HasIndex(indexExpression: l => l.CourseContentId, name: "FK_Lessons_CourseContents");
            builder.HasQueryFilter(l => !l.DeletedDate.HasValue);
        }
    }
}
