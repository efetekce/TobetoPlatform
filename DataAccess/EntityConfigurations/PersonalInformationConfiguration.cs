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
            builder.ToTable("PersonalInformations").HasKey(pi => pi.Id);
            builder.Property(pi => pi.Id).HasColumnName("Id").IsRequired();
            builder.Property(pi => pi.CountryId).HasColumnName("CountryId").IsRequired();
            builder.Property(pi => pi.CityId).HasColumnName("CityId").IsRequired();
            builder.Property(pi => pi.FirstName).HasColumnName("FirstName").IsRequired();
            builder.Property(pi => pi.LastName).HasColumnName("LastName").IsRequired();
            builder.Property(pi => pi.PhoneNumber).HasColumnName("PhoneNumber").IsRequired();
            builder.Property(pi => pi.BirthDate).HasColumnName("BirthDate").IsRequired();
            builder.Property(pi => pi.NationalIdentity).HasColumnName("NationalIdentity").IsRequired();
            builder.Property(pi => pi.Email).HasColumnName("Email").IsRequired();
            builder.Property(pi => pi.District).HasColumnName("District").IsRequired();
            builder.Property(pi => pi.NeighborhoodStreet).HasColumnName("NeighborhoodStreet");
            builder.Property(pi => pi.AboutMe).HasColumnName("AboutMe");
            builder.HasIndex(indexExpression: pi => pi.CountryId, name: "FK_PersonalInformations_Countries");
            builder.HasIndex(indexExpression: pi => pi.CityId, name: "FK_PersonalInformations_Cities");
            builder.HasQueryFilter(pi => !pi.DeletedDate.HasValue);
        }
    }
}
