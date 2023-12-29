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
            builder.ToTable("ProfileLanguages").HasKey(o => o.Id);
            builder.Property(o => o.Id).HasColumnName("Id").IsRequired();
            builder.Property(o => o.ProfileId).HasColumnName("ProfileId").IsRequired();
            builder.Property(o => o.LanguageId).HasColumnName("LanguageId");
            builder.Property(o => o.LanguageLevelId).HasColumnName("LanguageLevelId");

            builder.HasQueryFilter(e => !e.DeletedDate.HasValue);
        }
    }
}
