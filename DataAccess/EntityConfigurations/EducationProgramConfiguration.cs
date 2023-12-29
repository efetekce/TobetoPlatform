using Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.EntityConfigurations
{
    public class EducationProgramConfiguration : IEntityTypeConfiguration<EducationProgram>
    {
        public void Configure(EntityTypeBuilder<EducationProgram> builder)
        {
            builder.ToTable("EducationPrograms").HasKey(ep => ep.Id);
            builder.Property(ep => ep.Id).HasColumnName("Id").IsRequired();
            builder.Property(ep => ep.UniversityId).HasColumnName("UniversityId").IsRequired();
            builder.Property(ep => ep.Name).HasColumnName("Name");
            builder.Property(ep => ep.Visibility).HasColumnName("Visibility");
            builder.HasIndex(indexExpression: ep => ep.UniversityId, name: "FK_EducationPrograms_Universities");
            builder.HasQueryFilter(ep => !ep.DeletedDate.HasValue);
        }
    }
}
