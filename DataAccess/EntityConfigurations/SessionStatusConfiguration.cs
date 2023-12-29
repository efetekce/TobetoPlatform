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
    public class SessionStatusConfiguration : IEntityTypeConfiguration<SessionStatus>
    {
        public void Configure(EntityTypeBuilder<SessionStatus> builder)
        {
            builder.ToTable("SessionStatuses").HasKey(s => s.Id);
            builder.Property(ss => ss.Id).HasColumnName("Id").IsRequired();
            builder.Property(ss => ss.AccountId).HasColumnName("AccountId").IsRequired();
            builder.Property(ss => ss.Status).HasColumnName("Status");
            builder.Property(ss => ss.LoginTime).HasColumnName("LoginTime").IsRequired();
            builder.Property(ss => ss.LogoutTime).HasColumnName("LogoutTime").IsRequired();
            builder.HasIndex(indexExpression: ss => ss.AccountId, name: "FK_SessionStatuses_Accounts");
            builder.HasQueryFilter(ss => !ss.DeletedDate.HasValue);
        }
    }
}
