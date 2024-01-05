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
    public class OrganizationConfiguration:IEntityTypeConfiguration<Organization>
    {
        public void Configure(EntityTypeBuilder<Organization> builder)
        {
            builder.ToTable("Organizations").HasKey(o => o.Id);
            builder.Property(o => o.Id).HasColumnName("Id").IsRequired();
            builder.Property(o => o.AddressId).HasColumnName("AddressId").IsRequired();
            builder.Property(o => o.Name).HasColumnName("Name");
            builder.Property(o => o.ContactNumber).HasColumnName("ContactNumber");

            //builder
            //    .HasOne(o => o.Address)
            //    .WithMany()
            //    .HasForeignKey(o => o.AddressId)
            //    .OnDelete(DeleteBehavior.Restrict);
            builder.HasQueryFilter(e => !e.DeletedDate.HasValue);
        }
    }
}
