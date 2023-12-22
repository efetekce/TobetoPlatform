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
    public class MembershipStatusConfiguration:IEntityTypeConfiguration<MembershipStatus>
    {
        public void Configure(EntityTypeBuilder<MembershipStatus> builder)
        {
            builder.ToTable("MembershipStatus").HasKey(m=>m.Id);
            builder.Property(m=>m.Id).HasColumnName("Id").IsRequired();
            builder.Property(m => m.AccountId).HasColumnName("AccountId").IsRequired();
            builder.Property(m=>m.Status).HasColumnName("Status");
            builder.Property(m => m.JoinDate).HasColumnName("JoinDate");
            builder.Property(m => m.EndDate).HasColumnName("EndDate");
            builder.Property(m => m.CreatedDate).HasColumnName("CreatedDate").IsRequired();
            builder.Property(m => m.UpdatedDate).HasColumnName("UpdatedDate");
            builder.Property(m => m.DeletedDate).HasColumnName("DeletedDate");
        }
    }
}
