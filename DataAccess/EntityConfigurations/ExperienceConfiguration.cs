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
    public class ExperienceConfiguration : IEntityTypeConfiguration<Experience>
    {
        public void Configure(EntityTypeBuilder<Experience> builder)
        {
            builder.ToTable("Experiences").HasKey(e => e.Id);
            builder.Property(e => e.Id).HasColumnName("Id").IsRequired();
            builder.Property(e => e.ProfileId).HasColumnName("ProfileId").IsRequired();
            builder.Property(e => e.CompanyName).HasColumnName("CompanyName").IsRequired();
            builder.Property(e => e.Position).HasColumnName("Position").IsRequired();
            builder.Property(e => e.Field).HasColumnName("Field").IsRequired();
            builder.Property(e => e.City).HasColumnName("City").IsRequired();
            builder.Property(e => e.StartDate).HasColumnName("StartDate").IsRequired();
            builder.Property(e => e.EndDate).HasColumnName("EndDate").IsRequired();
            builder.Property(e => e.JobDescription).HasColumnName("JobDescription").IsRequired();
            builder.Property(e => e.CreatedDate).HasColumnName("CreatedDate").IsRequired();
            builder.Property(e => e.UpdatedDate).HasColumnName("UpdatedDate");
            builder.Property(e => e.DeletedDate).HasColumnName("DeletedDate");
            builder.HasIndex(indexExpression: e => e.CompanyName, name: "UK_Educations_CompanyName").IsUnique();

            builder.HasQueryFilter(e => !e.DeletedDate.HasValue);
        }
    }
}
