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
    public class ProfileLanguageConfiguration : IEntityTypeConfiguration<ProfileLanguage>
    {
        public void Configure(EntityTypeBuilder<ProfileLanguage> builder)
        {
        builder.ToTable("ProfileLanguages").HasKey(pl => pl.Id);
        builder.Property(pl => pl.Id).HasColumnName("Id").IsRequired();
        builder.Property(pl => pl.ProfileId).HasColumnName("ProfileId").IsRequired();
        builder.Property(pl => pl.LanguageId).HasColumnName("LanguageId").IsRequired();
        builder.Property(pl => pl.LanguageLevelId).HasColumnName("LanguageLevelId").IsRequired();
        //builder.HasIndex(indexExpression: pl => pl.ProfileId, name: "FK_ProfileLanguages_Skills");
        builder.HasIndex(indexExpression: pl => pl.LanguageId, name: "FK_ProfileLanguages_ForeignLanguages");
        builder.HasIndex(indexExpression: pl => pl.LanguageLevelId, name: "FK_ProfileLanguages_ForeignLanguagesLevels");
        builder.HasQueryFilter(pl => !pl.DeletedDate.HasValue);
        }
    }
}
