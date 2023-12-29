using Core.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.EntityConfigurations
{
    public class OperationClaimConfiguration : IEntityTypeConfiguration<OperationClaim>
    {
        public void Configure(EntityTypeBuilder<OperationClaim> builder)
        {
            builder.ToTable("OperationClaims").HasKey(o => o.Id);
            builder.Property(o => o.Id).HasColumnName("Id").IsRequired();
            builder.Property(o => o.Name).HasColumnName("Name").IsRequired();
            builder.HasQueryFilter(o => !o.DeletedDate.HasValue);
            builder.HasMany(o => o.Users).WithMany(o => o.OperationClaims);//Many-to-Many
            builder.HasMany(o => o.UserOperationClaims).WithOne(o => o.OperationClaim).HasForeignKey(o => o.OperationClaimId);
        }
    }
}
