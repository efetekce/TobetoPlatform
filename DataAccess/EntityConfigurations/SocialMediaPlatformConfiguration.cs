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
    public class SocialMediaPlatformConfiguration : IEntityTypeConfiguration<SocialMediaPlatform>
    {
        public void Configure(EntityTypeBuilder<SocialMediaPlatform> builder)
        {
            builder.ToTable("SocialMediaPlatforms").HasKey(smp => smp.Id);
            builder.Property(smp => smp.Id).HasColumnName("Id").IsRequired();
            builder.Property(smp => smp.Name).HasColumnName("Name").IsRequired();
            builder.Property(smp => smp.Link).HasColumnName("Link").IsRequired();
            builder.Property(smp => smp.Priority).HasColumnName("Priority");
            builder.Property(smp => smp.Visibility).HasColumnName("Visibility");
            builder.HasQueryFilter(smp => !smp.DeletedDate.HasValue);
        }
    }
}
