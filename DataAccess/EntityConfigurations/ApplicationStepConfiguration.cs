using Entities.Concretes;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.EntityConfigurations
{
    public class ApplicationStepConfiguration : IEntityTypeConfiguration<ApplicationStep>
    {
        public void Configure(EntityTypeBuilder<ApplicationStep> builder)
        {
            builder.ToTable("ApplicationSteps").HasKey(a => a.Id);
            builder.Property(a => a.Id).IsRequired();
            builder.Property(a => a.Name);
            builder.Property(a => a.Priority);
            builder.Property(a => a.Visibility);
        }
    }
}
