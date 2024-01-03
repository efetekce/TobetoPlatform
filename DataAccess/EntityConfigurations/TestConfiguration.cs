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
    public class TestConfiguration : IEntityTypeConfiguration<Test>
    {
        public void Configure(EntityTypeBuilder<Test> builder)
        {
            builder.ToTable("Tests").HasKey(t => t.Id);
            builder.Property(t => t.Id).HasColumnName("Id").IsRequired();
            builder.Property(t => t.QuestionId).HasColumnName("QuestionId").IsRequired();
            builder.Property(t => t.Name).HasColumnName("Name").IsRequired();
            builder.Property(t => t.Description).HasColumnName("Description");
            builder.Property(t => t.NumberOfQuestions).HasColumnName("NumberOfQuestions").IsRequired();
            builder.Property(t => t.Duration).HasColumnName("Duration").IsRequired();
            builder.Property(t => t.StartTime).HasColumnName("StartTime").IsRequired();
            builder.Property(t => t.EndTime).HasColumnName("EndTime").IsRequired();
            builder.Property(t => t.Priority).HasColumnName("Priority");
            builder.Property(t => t.Visibility).HasColumnName("Visibility");
            builder.HasIndex(indexExpression: t => t.QuestionId, name: "FK_Tests_Questions");

            builder.HasQueryFilter(t => !t.DeletedDate.HasValue);
        }
    }
}
