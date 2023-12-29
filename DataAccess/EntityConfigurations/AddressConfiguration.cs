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
    public class AddressConfiguration : IEntityTypeConfiguration<Address>
    {
        public void Configure(EntityTypeBuilder<Address> builder)
        {
            builder.ToTable("Addresses").HasKey(a => a.Id);
            builder.Property(a => a.Id).HasColumnName("Id").IsRequired();
            builder.Property(a => a.CountryId).HasColumnName("CountryId").IsRequired();
            builder.Property(a => a.CityId).HasColumnName("CityId").IsRequired();
            builder.Property(a => a.DistrictId).HasColumnName("DistrictId").IsRequired();
            builder.Property(a => a.Detail).HasColumnName("Detail");

            // Relationships
            builder
                .HasOne(a => a.Country)
                .WithMany()
                .HasForeignKey(a => a.CountryId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasOne(a => a.City)
                .WithMany()
                .HasForeignKey(a => a.CityId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasOne(a => a.District)
                .WithMany()
                .HasForeignKey(a => a.DistrictId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
