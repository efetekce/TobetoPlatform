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
    public class AccountPasswordConfiguration : IEntityTypeConfiguration<AccountPassword>
    {
        public void Configure(EntityTypeBuilder<AccountPassword> builder)
        {
            builder.ToTable("AccountPasswords").HasKey(a => a.Id);
            builder.Property(a => a.Id).HasColumnName("Id").IsRequired();
            builder.Property(a => a.AccountId).HasColumnName("AccountId");
            builder.Property(a => a.Priority).HasColumnName("Priority");
            builder.HasIndex(indexExpression: a => a.AccountId, name: "FK_AccountPasswords_Accounts");
            builder.HasQueryFilter(a => !a.DeletedDate.HasValue);
        }
    }
}
