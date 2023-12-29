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
            builder.Property(o => o.Priority).HasColumnName("Priority");
            builder.Property(o => o.Visibility).HasColumnName("Visibility");
            builder.Property(o => o.Name).HasColumnName("Name");
            builder.Property(o => o.ContactNumber).HasColumnName("ContactNumber");
            builder.HasIndex(indexExpression: o => o.AddressId, name: "FK_Organizations_Addresses");
            builder.HasQueryFilter(o => !o.DeletedDate.HasValue);
        }
    }
}
