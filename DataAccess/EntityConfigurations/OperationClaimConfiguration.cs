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
            builder.ToTable("OperationClaims").HasKey(b => b.Id);
            //builder.Property(b => b.Id).HasColumnName("CategoryId").IsRequired();
            builder.Property(b => b.Name).HasColumnName("Name").IsRequired();
            builder.HasIndex(indexExpression: b => b.Name, name: "UK_Categories_Name").IsUnique();
            builder.HasMany(b => b.UserOperationClaims);
            builder.HasMany(b => b.Users);
            builder.HasQueryFilter(b => !b.DeletedDate.HasValue);
        }
    }
}
