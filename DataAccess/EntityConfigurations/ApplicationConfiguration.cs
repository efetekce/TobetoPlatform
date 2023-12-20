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
    public class ApplicationConfiguration:IEntityTypeConfiguration<Application>
    {
        public void Configure(EntityTypeBuilder<Application>builder)
        {
            builder.ToTable("Applications").HasKey(a=>a.Id);
            builder.Property(a => a.Id).IsRequired();
            builder.Property(a => a.OrganizationId);
            builder.Property(a => a.Priority);
            builder.Property(a => a.Visibility);
            builder.Property(a => a.Title).HasMaxLength(255);
            builder.Property(a => a.Content);
            builder.Property(a => a.PublishedDate);
        }
    }
}
