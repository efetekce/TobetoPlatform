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
            builder.ToTable("Lessons").HasKey(c => c.Id);
            builder.Property(c => c.Id).HasColumnName("Id").IsRequired();
            builder.Property(c => c.CourseId).HasColumnName("CourseId").IsRequired();
            builder.Property(c => c.CourseContentId).HasColumnName("CourseContentId").IsRequired();
            builder.Property(c => c.Name).HasColumnName("Name").IsRequired();
            builder.Property(c => c.VideoDuration).HasColumnName("VideoDuration").IsRequired();

        }
    }
}
