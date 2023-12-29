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
    public class AnswerConfiguration : IEntityTypeConfiguration<Answer>
    {
        public void Configure(EntityTypeBuilder<Answer> builder)
        {
        builder.ToTable("Answers").HasKey(a => a.Id);
        builder.Property(a => a.Id).HasColumnName("Id").IsRequired();
        builder.Property(a => a.QuestionId).HasColumnName("QuestionId").IsRequired();
        builder.Property(a => a.ProfileId).HasColumnName("ProfileId").IsRequired();
        builder.Property(a => a.LanguageName).HasColumnName("LanguageName");
        builder.Property(a => a.Content).HasColumnName("Content");
        builder.Property(a => a.LanguageLevel).HasColumnName("LanguageLevel");
        builder.Property(a => a.Name).HasColumnName("Name");
            builder.HasIndex(indexExpression: a => a.QuestionId, name: "FK_Answers_Questions");
            //????builder.HasIndex(indexExpression: a => a.ProfileId, name: "FK_Answers_Questions");
            builder.HasQueryFilter(a => !a.DeletedDate.HasValue);
        }
    }
}
