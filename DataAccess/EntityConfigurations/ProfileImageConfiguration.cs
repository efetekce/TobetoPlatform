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
    public class ProfileImageConfiguration : IEntityTypeConfiguration<ProfileImage>
    {
        public void Configure(EntityTypeBuilder<ProfileImage> builder)
        {
            builder.ToTable("ProfileImages").HasKey(o => o.Id);
            builder.Property(o => o.Id).HasColumnName("Id").IsRequired();
            builder.Property(o => o.ProfileId).HasColumnName("ProfileId").IsRequired();
            builder.Property(o => o.ImagePath).HasColumnName("ImagePath");




            builder.HasQueryFilter(e => !e.DeletedDate.HasValue);
        }
    }
}
