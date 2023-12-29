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
            builder.Property(a => a.Id).HasColumnName("Id").IsRequired();
            builder.Property(a => a.AccountId).HasColumnName("AccountId").IsRequired();
            builder.Property(a => a.ApplicationId).HasColumnName("ApplicationId").IsRequired();
            builder.Property(a => a.ApplicationStepId).HasColumnName("ApplicationStepId").IsRequired();

            builder.HasIndex(indexExpression: a => a.AccountId, name: "FK_AccountApplications_Accounts");
            builder.HasIndex(indexExpression: a => a.ApplicationId, name: "FK_AccountApplications_Applications");
            builder.HasIndex(indexExpression: a => a.ApplicationStepId, name: "FK_AccountApplications_ApplicationSteps");
            builder.HasQueryFilter(a => !a.DeletedDate.HasValue);
        }
    }
}
