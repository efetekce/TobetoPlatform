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
    public class AccountConfiguration : IEntityTypeConfiguration<Account>
    {
        public void Configure(EntityTypeBuilder<Account> builder)
        {
            builder.ToTable("Accounts").HasKey(b => b.Id);
            builder.Property(a => a.Id).HasColumnName("Id").IsRequired();
            builder.Property(a => a.FirstName).HasColumnName("FirstName").IsRequired();
            builder.Property(a => a.LastName).HasColumnName("LastName").IsRequired();
            builder.Property(a => a.NationalId).HasColumnName("NationalId").IsRequired();
            builder.Property(a => a.Email).HasColumnName("Email").IsRequired();
            builder.Property(a => a.BirthDate).HasColumnName("BirthDate").IsRequired();
            builder.Property(a => a.PhoneNumber).HasColumnName("PhoneNumber").IsRequired();
            //builder.Property(a => a.Status).HasColumnName("Status").IsRequired();
            builder.Property(a => a.Address).HasColumnName("Address");
            builder.Property(a => a.Description).HasColumnName("Description");
            builder.HasQueryFilter(a => !a.DeletedDate.HasValue);

            //builder.HasOne(c => c.Country).WithOne(country => country.Account).HasForeignKey<Account>(a => a.CountryId);
            //builder.HasOne(c => c.City).WithOne(city => city.Account).HasForeignKey<Account>(a => a.CityId);
            //builder.HasOne(d => d.District).WithOne(district => district.Account).HasForeignKey<Account>(a => a.DistrictId);

            // builder.HasQueryFilter(a => Convert.ToInt32(a.NationalId) >= 0 && Convert.ToInt32(a.NationalId) <= 99999999999);
        }

       
    }
}
