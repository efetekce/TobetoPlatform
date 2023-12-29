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
    public class EducationStatusConfiguration:IEntityTypeConfiguration<EducationStatus>
    {
        public void Configure(EntityTypeBuilder<EducationStatus> builder)
        {
            builder.ToTable("EducationStatuses").HasKey(e=>e.Id);
            builder.Property(e => e.Id).HasColumnName("Id").IsRequired();
            builder.Property(e => e.Name).HasColumnName("Name").IsRequired();
            builder.Property(e => e.Priority).HasColumnName("Priority");
            builder.Property(e => e.Visibility).HasColumnName("Visibility");
            builder.HasQueryFilter(e => !e.DeletedDate.HasValue);
        }
    }
}
