using Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.EntityConfigurations
{
    public class AssessmentConfiguration : IEntityTypeConfiguration<Assessment>
    {
        public void Configure(EntityTypeBuilder<Assessment> builder)
        {
            builder.ToTable("Assessments").HasKey(a => a.Id);

            builder.Property(a => a.Id).HasColumnName("Id").IsRequired();
            builder.Property(a => a.QuestionId).HasColumnName("QuestionId").IsRequired();
            builder.Property(a => a.Name).HasColumnName("Name").IsRequired();
            builder.Property(a => a.Description).HasColumnName("Description").HasMaxLength(255);
            builder.Property(a => a.NumberOfQuestions).HasColumnName("NumberOfQuestions");
            builder.Property(a => a.Duration).HasColumnName("Duration");
            builder.Property(a => a.StartTime).HasColumnName("StartTime");
            builder.Property(a => a.EndTime).HasColumnName("EndTime");
            builder.Property(a => a.Priority).HasColumnName("Priority");
            builder.Property(a => a.Visibility).HasColumnName("Visibility");
            builder.HasQueryFilter(e => !e.DeletedDate.HasValue);
        }
    }
}
