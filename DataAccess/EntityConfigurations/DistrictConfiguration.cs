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
    public class DistrictConfiguration:IEntityTypeConfiguration<District>
    {
        public void Configure(EntityTypeBuilder<District> builder)
        {
            builder.ToTable("Districts").HasKey(d => d.Id);
            builder.Property(d => d.Name).HasColumnName("Name").IsRequired();

            builder.HasOne(d => d.City).WithMany(city => city.Districts).HasForeignKey(d => d.CityId).IsRequired().OnDelete(DeleteBehavior.NoAction);
        }
    }
}
