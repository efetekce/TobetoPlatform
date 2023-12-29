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
            builder.Property(a => a.AddressId).HasColumnName("AddressId");
            builder.Property(a => a.FirstName).HasColumnName("FirstName").IsRequired();
            builder.Property(a => a.LastName).HasColumnName("LastName").IsRequired();
            builder.Property(a => a.NationalId).HasColumnName("NationalId").IsRequired();
            builder.Property(a => a.BirthDate).HasColumnName("BirthDate").IsRequired();
            builder.Property(a => a.PhoneNumber).HasColumnName("PhoneNumber").IsRequired();
            builder.Property(a => a.Status).HasColumnName("Status").IsRequired();
            builder.HasIndex(indexExpression: a => a.NationalId, name: "UK_Accounts_NationalId").IsUnique();
            builder.HasIndex(indexExpression: a => a.AddressId, name: "FK_Accounts_Addresses");
            builder.HasQueryFilter(a => !a.DeletedDate.HasValue);

            //builder.HasMany(a => a.AccountSocialMedias);
            //builder.HasMany(a => a.AccountEducations);
            //builder.HasMany(a => a.AccountForeignLanguages);
            // builder.HasQueryFilter(a => Convert.ToInt32(a.NationalId) >= 0 && Convert.ToInt32(a.NationalId) <= 99999999999);
        }
    }
}
