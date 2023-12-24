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
            builder.ToTable("SessionStatus").HasKey(s => s.Id);
            builder.Property(s => s.Id).HasColumnName("Id").IsRequired();
            builder.Property(s => s.AccountId).HasColumnName("AccountId").IsRequired();
            builder.Property(s => s.Status).HasColumnName("Status");
            builder.Property(s => s.LoginTime).HasColumnName("LoginTime").IsRequired();
            builder.Property(s => s.LogoutTime).HasColumnName("LogoutTime").IsRequired();
            builder.HasQueryFilter(e => !e.DeletedDate.HasValue);
        }
    }
}
