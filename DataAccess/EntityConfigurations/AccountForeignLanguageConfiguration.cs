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
    public class AccountForeignLanguageConfiguration:IEntityTypeConfiguration<AccountForeignLanguage>
    {
        public void Configure(EntityTypeBuilder<AccountForeignLanguage> builder)
        {
        builder.ToTable("AccountForeignLanguages").HasKey(af => af.Id);
        builder.Property(af => af.Id).HasColumnName("Id").IsRequired();
        builder.Property(af => af.AccountId).HasColumnName("AccountId").IsRequired();
        builder.Property(af => af.ForeignLanguageId).HasColumnName("ForeignLanguageId").IsRequired();
        builder.Property(af => af.ForeignLanguageLevelId).HasColumnName("ForeignLanguageLevelId").IsRequired();
        //builder.HasIndex(indexExpression: af => af.AccountId, name: "FK_AccountForeignLanguages_Accounts");
        //builder.HasIndex(indexExpression: af => af.ForeignLanguageId, name: "FK_AccountForeignLanguages_ForeignLanguages");
        //builder.HasIndex(indexExpression: af => af.ForeignLanguageLevelId, name: "FK_AccountForeignLanguages_ForeignLanguagesLevels");
            builder.HasQueryFilter(af => !af.DeletedDate.HasValue);
        }
    }
}
