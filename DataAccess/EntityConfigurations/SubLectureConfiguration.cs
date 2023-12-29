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
    public class SubLectureConfiguration : IEntityTypeConfiguration<SubLecture>
    {
        public void Configure(EntityTypeBuilder<SubLecture> builder)
        {
            //    public int LectureId { get; set; }
            //public string Name { get; set; }
            //public string Status { get; set; }
            //public int Duration { get; set; }

            builder.ToTable("SubLectures").HasKey(sl => sl.Id);
            builder.Property(sl => sl.Id).HasColumnName("Id").IsRequired();
            builder.Property(sl => sl.LectureId).HasColumnName("LectureId").IsRequired();
            builder.Property(sl => sl.Name).HasColumnName("Name").IsRequired();
            builder.Property(sl => sl.Status).HasColumnName("Status");
            builder.Property(sl => sl.Duration).HasColumnName("Duration").IsRequired();

            //builder.HasIndex(indexExpression: sl => sl.SkillId, name: "FK_SubLectures_Skills");

            builder.HasQueryFilter(sl => !sl.DeletedDate.HasValue);
        }
    }
}
