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
            builder.Property(a => a.FirstName).HasColumnName("FirstName").IsRequired();
            builder.Property(a => a.LastName).HasColumnName("LastName").IsRequired();
            builder.Property(a => a.NationalId).HasColumnName("NationalId").IsRequired();
            builder.Property(a => a.Email).HasColumnName("Email").IsRequired();
            builder.Property(a => a.BirthDate).HasColumnName("BirthDate").IsRequired();
            builder.Property(a => a.PhoneNumber).HasColumnName("PhoneNumber").IsRequired();
            //builder.Property(a => a.Status).HasColumnName("Status").IsRequired();
            builder.Property(a => a.Address).HasColumnName("Address");
            builder.Property(a => a.Description).HasColumnName("Description");

            //builder.HasOne(a => a.Country).WithOne().HasForeignKey<Country>(c => c.Id);
            //builder.HasOne(a => a.City).WithOne().HasForeignKey<City>(c => c.Id);
            //builder.HasOne(a => a.District).WithOne().HasForeignKey<District>(c => c.Id);

            builder.HasMany(a => a.AccountExperience).WithOne(b=>b.Account).HasForeignKey(c=>c.AccountId);
            builder.HasMany(a => a.AccountEducation).WithOne(b => b.Account).HasForeignKey(c => c.AccountId);
            builder.HasMany(a => a.AccountSkill).WithOne(b => b.Account).HasForeignKey(c => c.AccountId);
            builder.HasMany(a => a.AccountCertificate).WithOne(b => b.Account).HasForeignKey(c => c.AccountId);
            builder.HasMany(a => a.AccountSocialMedia).WithOne(b => b.Account).HasForeignKey(c => c.AccountId);
            builder.HasMany(a => a.AccountForeignLanguage).WithOne(b => b.Account).HasForeignKey(c => c.AccountId);

            // builder.HasQueryFilter(a => Convert.ToInt32(a.NationalId) >= 0 && Convert.ToInt32(a.NationalId) <= 99999999999);

            builder.HasQueryFilter(a => !a.DeletedDate.HasValue);
        }

       
    }
}
