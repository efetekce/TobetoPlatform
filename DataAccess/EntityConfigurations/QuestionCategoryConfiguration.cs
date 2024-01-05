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
    public class QuestionCategoryConfiguration : IEntityTypeConfiguration<QuestionCategory>
    {
        public void Configure(EntityTypeBuilder<QuestionCategory> builder)
        {
        builder.ToTable("QuestionCategories").HasKey(qc => qc.Id);
        builder.Property(qc => qc.Id).HasColumnName("Id").IsRequired();
        builder.Property(qc => qc.Name).HasColumnName("Name").IsRequired();
        builder.HasQueryFilter(qc => !qc.DeletedDate.HasValue);
        }
    }
}
