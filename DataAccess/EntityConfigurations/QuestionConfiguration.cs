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
        builder.ToTable("Questions").HasKey(q => q.Id);
        builder.Property(q => q.Id).HasColumnName("Id").IsRequired();
        builder.Property(q => q.AssessmentId).HasColumnName("AssessmentId").IsRequired();
        builder.Property(q => q.SurveyId).HasColumnName("SurveyId").IsRequired();
        builder.Property(q => q.QuestionCategoryId).HasColumnName("QuestionCategoryId").IsRequired();
        builder.Property(q => q.Content).HasColumnName("Content");
        builder.Property(q => q.IsActive).HasColumnName("IsActive").IsRequired();

        //builder.HasIndex(indexExpression: q => q.AssessmentId, name: "FK_Questions_Assessments");
        //builder.HasIndex(indexExpression: q => q.SurveyId, name: "FK_Questions_Surveys");
        //builder.HasIndex(indexExpression: q => q.QuestionCategoryId, name: "FK_Questions_QuestionCategories");
        builder.HasQueryFilter(q => !q.DeletedDate.HasValue);
        }
    }
}
