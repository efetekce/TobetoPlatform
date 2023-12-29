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
            builder.HasIndex(indexExpression: a => a.CountryId, name: "FK_Addresses_Countries");
            builder.HasIndex(indexExpression: a => a.CityId, name: "FK_Addresses_Cities");
            builder.HasIndex(indexExpression: a => a.DistrictId, name: "FK_Addresses_Districts");
            builder.HasQueryFilter(a => !a.DeletedDate.HasValue);
        }
    }
}
