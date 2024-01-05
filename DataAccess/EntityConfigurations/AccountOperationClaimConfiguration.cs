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
    public class AccountOperationClaimConfiguration : IEntityTypeConfiguration<AccountOperationClaim>
    {
        public void Configure(EntityTypeBuilder<AccountOperationClaim> builder)
        {
            builder.ToTable("AccountOperationClaims").HasKey(ao => ao.Id);
            builder.Property(ao => ao.Id).HasColumnName("Id").IsRequired();
            builder.Property(ao => ao.AccountId).HasColumnName("AccountId").IsRequired();
            builder.Property(ao => ao.OperationClaimId).HasColumnName("OperationClaimId").IsRequired();
            builder.Property(ao => ao.IsActive).HasColumnName("IsActive");
            //builder.HasIndex(indexExpression: ao => ao.AccountId, name: "FK_AccountOperationClaims_Accounts");
            //builder.HasIndex(indexExpression: ao => ao.OperationClaimId, name: "FK_AccountOperationClaims_OperationClaims");
            builder.HasQueryFilter(ao => !ao.DeletedDate.HasValue);
        }
    }
}
