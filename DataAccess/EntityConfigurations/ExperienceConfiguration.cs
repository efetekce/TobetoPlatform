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

            builder.Property(e => e.Id).HasColumnName("ExperienceId").IsRequired();

            builder.Property(e => e.ProfileId).HasColumnName("ProfileId");

            builder.Property(e => e.CompanyName).HasColumnName("CompanyName");

            builder.Property(e => e.Position).HasColumnName("Position");

            builder.Property(e => e.Field).HasColumnName("Field");

            builder.Property(e => e.City).HasColumnName("City");

            builder.Property(e => e.StartDate).HasColumnName("StartDate");

            builder.Property(e => e.EndDate).HasColumnName("EndDate");

            builder.Property(e => e.JobDescription).HasColumnName("JobDescription");
        }
    }
}
