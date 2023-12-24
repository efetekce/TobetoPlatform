using Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.EntityConfigurations
{
    public class EducationProgramConfiguration:IEntityTypeConfiguration<EducationProgram>
    {
        public void Configure(EntityTypeBuilder<EducationProgram>builder)
        {
            builder.ToTable("EducationPrograms").HasKey(e=>e.Id);
            builder.Property(e=>e.Id).HasColumnName("Id").IsRequired();
            builder.Property(e=>e.UniversityId).HasColumnName("UniversityId").IsRequired();
            builder.Property(e=>e.Name).HasColumnName("Name");
            builder.Property(e=>e.Visibility).HasColumnName("Visibility");
            builder.HasQueryFilter(e => !e.DeletedDate.HasValue);
        }
    }
}
