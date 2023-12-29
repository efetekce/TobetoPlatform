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
    public class QuestionConfiguration : IEntityTypeConfiguration<Question>
    {
        public void Configure(EntityTypeBuilder<Question> builder)
        {
            builder.ToTable("Questions").HasKey(o => o.Id);
            builder.Property(o => o.Id).HasColumnName("Id").IsRequired();
            builder.Property(o => o.AssessmentId).HasColumnName("AssessmentId").IsRequired();
            builder.Property(o => o.SurveyId).HasColumnName("SurveyId");
            builder.Property(o => o.QuestionCategoryId).HasColumnName("QuestionCategoryId");
            builder.Property(o => o.Content).HasColumnName("Content");
            builder.Property(o => o.IsActive).HasColumnName("IsActive");

            builder.HasQueryFilter(e => !e.DeletedDate.HasValue);
        }
    }
}
