using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concretes;

namespace DataAccess.EntityConfigurations
{
    public class EducationConfiguration : IEntityTypeConfiguration<Education>
    {
        public void Configure(EntityTypeBuilder<Education> builder)
        {
            builder.ToTable("Educations").HasKey(e => e.Id);

            builder.Property(e => e.Id).HasColumnName("EducationId").IsRequired();

            builder.Property(e => e.ProfileId).HasColumnName("ProfileId");

            builder.Property(e => e.Status).HasColumnName("Status");

            builder.Property(e => e.University).HasColumnName("University").IsRequired();

            builder.Property(e => e.Major).HasColumnName("Major").IsRequired();

            builder.Property(e => e.StartYear).HasColumnName("StartYear").IsRequired();

            builder.Property(e => e.EndYear).HasColumnName("EndYear").IsRequired();

            builder.Property(e => e.GraduationYear).HasColumnName("GraduationYear").IsRequired();
        }
    }
}
