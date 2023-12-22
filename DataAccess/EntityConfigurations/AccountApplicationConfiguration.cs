using Entities.Concretes;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.EntityConfigurations
{
    public class AccountApplicationConfiguration : IEntityTypeConfiguration<AccountApplication>
    {
        public void Configure(EntityTypeBuilder<AccountApplication> builder)
        {
            //accounts table,application table,applicationstep table bağlantı 
            builder.ToTable("AccountApplications").HasKey(a => a.Id);
            builder.Property(a => a.Id).IsRequired();
            builder.Property(a => a.AccountId).IsRequired();
            builder.Property(a => a.ApplicationId).IsRequired();
            builder.Property(a => a.ApplicationStepId).IsRequired();
        }
    }
}
