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
            builder.Property(e => e.Position).HasColumnName("Position");
            builder.Property(e => e.CityId).HasColumnName("CityId").IsRequired();
            builder.Property(e => e.Field).HasColumnName("Field");
            builder.Property(e => e.StartDate).HasColumnName("StartDate");
            builder.Property(e => e.EndDate).HasColumnName("EndDate");
            builder.Property(e => e.JobDescription).HasColumnName("JobDescription");
            builder.Property(e => e.CreatedDate).HasColumnName("CreatedDate").IsRequired();
            builder.Property(e => e.UpdatedDate).HasColumnName("UpdatedDate");
            builder.Property(e => e.DeletedDate).HasColumnName("DeletedDate");

            builder.HasQueryFilter(e => !e.DeletedDate.HasValue);
        }
    }
}
