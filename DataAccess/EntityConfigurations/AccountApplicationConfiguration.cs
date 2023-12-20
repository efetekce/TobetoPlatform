using Entities.Concretes;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.EntityConfigurations
{
    public class AccountApplicationConfiguration : IEntityTypeConfiguration<AccountApplication>
    {
        public void Configure(EntityTypeBuilder<AccountApplication> builder)
        {
            builder.ToTable("AccountApplications").HasKey(a => a.Id);
            builder.Property(a => a.Id).IsRequired();
            builder.Property(a => a.AccountId);
            builder.Property(a => a.ApplicationId);
            builder.Property(a => a.ApplicationStepId);
        }
    }
}
