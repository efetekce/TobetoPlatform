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
    public class MembershipStatusConfiguration : IEntityTypeConfiguration<MembershipStatus>
    {
        public void Configure(EntityTypeBuilder<MembershipStatus> builder)
        {
            builder.ToTable("MembershipStatuses").HasKey(ms => ms.Id);
            builder.Property(ms => ms.Id).HasColumnName("Id").IsRequired();
            builder.Property(ms => ms.AccountId).HasColumnName("AccountId").IsRequired();
            builder.Property(ms => ms.Status).HasColumnName("Status").IsRequired();
            builder.Property(ms => ms.JoinDate).HasColumnName("JoinDate").IsRequired();
            builder.Property(ms => ms.EndDate).HasColumnName("EndDate");
            builder.HasIndex(indexExpression: ms => ms.AccountId, name: "FK_MembershipStatuses_Accounts");
            builder.HasQueryFilter(ms => !ms.DeletedDate.HasValue);
        }
    }
}
