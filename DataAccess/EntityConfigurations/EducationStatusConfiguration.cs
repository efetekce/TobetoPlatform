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
    public class EducationStatusConfiguration : IEntityTypeConfiguration<EducationStatus>
    {
        public void Configure(EntityTypeBuilder<EducationStatus> builder)
        {
            builder.ToTable("EducationStatuses").HasKey(es => es.Id);
            builder.Property(es => es.Id).HasColumnName("Id").IsRequired();
            builder.Property(es => es.Name).HasColumnName("Name").IsRequired();
            builder.Property(es => es.Priority).HasColumnName("Priority");
            builder.Property(es => es.Visibility).HasColumnName("Visibility");
            builder.HasQueryFilter(es => !es.DeletedDate.HasValue);
        }
    }
}
