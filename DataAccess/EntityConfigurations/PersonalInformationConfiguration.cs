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
    public class PersonalInformationConfiguration : IEntityTypeConfiguration<PersonalInformation>
    {
        public void Configure(EntityTypeBuilder<PersonalInformation> builder)
        {
            builder.ToTable("PersonalInformations").HasKey(o => o.Id);
            builder.Property(o => o.Id).HasColumnName("Id").IsRequired();
            builder.Property(o => o.FirstName).HasColumnName("FirstName").IsRequired();
            builder.Property(o => o.LastName).HasColumnName("LastName");
            builder.Property(o => o.PhoneNumber).HasColumnName("PhoneNumber");
            builder.Property(o => o.NationalIdentity).HasColumnName("NationalIdentity");
            builder.Property(o => o.Country).HasColumnName("Country");
            builder.Property(o => o.City).HasColumnName("City");
            builder.Property(o => o.District).HasColumnName("District");
            builder.Property(o => o.NeighborhoodStreet).HasColumnName("NeighborhoodStreet");
            builder.Property(o => o.AboutMe).HasColumnName("AboutMe");


            builder
                .HasOne(o => o.Address)
                .WithMany()
                .HasForeignKey(o => o.AddressId)
                .OnDelete(DeleteBehavior.Restrict);
            builder.HasQueryFilter(e => !e.DeletedDate.HasValue);
        }
    }
}
