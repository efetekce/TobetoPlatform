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
    public class AccountExperienceConfiguration : IEntityTypeConfiguration<AccountExperience>
    {
        public void Configure(EntityTypeBuilder<AccountExperience> builder)
        {
            builder.ToTable("Experiences").HasKey(e => e.Id);
            builder.Property(e => e.Id).HasColumnName("Id").IsRequired();
            builder.Property(e => e.CompanyName).HasColumnName("CompanyName").IsRequired();
            builder.Property(e => e.Position).HasColumnName("Position");
            builder.Property(e => e.Sector).HasColumnName("Sector");
            builder.Property(e => e.StartDate).HasColumnName("StartDate");
            builder.Property(e => e.EndDate).HasColumnName("EndDate");
            builder.Property(e => e.JobDescription).HasColumnName("JobDescription");
            builder.HasQueryFilter(e => !e.DeletedDate.HasValue);

            builder.HasOne(a => a.City).WithMany().HasForeignKey(c => c.CityId).OnDelete(DeleteBehavior.NoAction);
        }
    }
}
