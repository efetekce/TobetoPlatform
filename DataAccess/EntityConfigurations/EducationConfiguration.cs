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
    public class EducationConfiguration : IEntityTypeConfiguration<Education>
    {
        public void Configure(EntityTypeBuilder<Education> builder)
        {
            builder.ToTable("Educations").HasKey(e => e.Id);
            builder.Property(e => e.Id).HasColumnName("Id").IsRequired();
            builder.Property(e => e.ProfileId).HasColumnName("ProfileId").IsRequired();
            builder.Property(e => e.Status).HasColumnName("Status").IsRequired();
            builder.Property(e => e.University).HasColumnName("University").IsRequired();
            builder.Property(e => e.Major).HasColumnName("Major").IsRequired();
            builder.Property(e => e.StartYear).HasColumnName("StartYear").IsRequired();
            builder.Property(e => e.EndYear).HasColumnName("EndYear").IsRequired();
            builder.Property(e => e.GraduationYear).HasColumnName("GraduationYear").IsRequired();
            builder.Property(e => e.CreatedDate).HasColumnName("CreatedDate").IsRequired();
            builder.Property(e => e.UpdatedDate).HasColumnName("UpdatedDate");
            builder.Property(e => e.DeletedDate).HasColumnName("DeletedDate");

            //builder.HasIndex(indexExpression: e => e.Status, name: "UK_Educations_Status").IsUnique();
            //one to many
            builder.HasQueryFilter(e => !e.DeletedDate.HasValue);
        }
    }
}
