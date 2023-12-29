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
    public class AccountTestResultConfiguration : IEntityTypeConfiguration<AccountTestResult>
    {
        public void Configure(EntityTypeBuilder<AccountTestResult> builder)
        {
            builder.ToTable("AccountTestResults").HasKey(atr => atr.Id);
            builder.Property(atr => atr.Id).HasColumnName("Id").IsRequired();
            builder.Property(atr => atr.AccountId).HasColumnName("AccountId").IsRequired();
            builder.Property(atr => atr.TestId).HasColumnName("TestId").IsRequired();
            builder.Property(atr => atr.Visibility).HasColumnName("Visibility");
            builder.Property(atr => atr.TotalCorrectAnswer).HasColumnName("TotalCorrectAnswer");
            builder.Property(atr => atr.TotalWrongAnswer).HasColumnName("TotalWrongAnswer");
            builder.Property(atr => atr.TotalBlankAnswer).HasColumnName("TotalBlankAnswer");
            builder.Property(atr => atr.Points).HasColumnName("Points");
            builder.HasIndex(indexExpression: atr => atr.AccountId, name: "FK_AccountTestResults_Accounts");
            builder.HasIndex(indexExpression: atr => atr.TestId, name: "FK_AccountTestResults_Tests");
            builder.HasQueryFilter(atr => !atr.DeletedDate.HasValue);
        }
    }
}
