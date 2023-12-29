using Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.EntityConfigurations
{
    public class ApplicationConfiguration : IEntityTypeConfiguration<Application>
    {
        public void Configure(EntityTypeBuilder<Application> builder)
        {
            builder.ToTable("Applications").HasKey(a => a.Id);
            builder.Property(a => a.Id).HasColumnName("Id").IsRequired();
            builder.Property(a => a.OrganizationId).HasColumnName("OrganizationId").IsRequired();
            builder.Property(a => a.Priority).HasColumnName("Priority");
            builder.Property(a => a.Visibility).HasColumnName("Visibility");
            builder.Property(a => a.Title).HasColumnName("Title").HasMaxLength(255);
            builder.Property(a => a.Content).HasColumnName("Content");
            builder.Property(a => a.PublishedDate).HasColumnName("PublishedDate");
            builder.HasQueryFilter(e => !e.DeletedDate.HasValue);
        }
    }
}
