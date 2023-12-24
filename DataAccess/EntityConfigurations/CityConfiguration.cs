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
    public class CityConfiguration : IEntityTypeConfiguration<City>
    {
        public void Configure(EntityTypeBuilder<City> builder)
        {
            builder.ToTable("Cities").HasKey(c => c.Id);
            builder.Property(c => c.Id).HasColumnName("Id").IsRequired();
            builder.Property(c => c.CountryId).HasColumnName("CountryId").IsRequired();
            builder.Property(c => c.Name).HasColumnName("Name");
            builder.Property(c => c.Priority).HasColumnName("Priority");
            builder.Property(c => c.Visibility).HasColumnName("Visibility");

            builder
                .HasOne(c => c.Country)
                .WithMany(co => co.Cities)
                .HasForeignKey(c => c.CountryId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
