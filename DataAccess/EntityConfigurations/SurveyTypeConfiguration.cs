using Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.EntityConfigurations
{
    public class SurveyTypeConfiguration : IEntityTypeConfiguration<SurveyType>
    {
        public void Configure(EntityTypeBuilder<SurveyType> builder)
        {
            builder.ToTable("SurveyTypes").HasKey(s=>s.Id);
            builder.Property(s=>s.Id).HasColumnName("Id").IsRequired();
            builder.Property(s=>s.Name).HasColumnName("Name").IsRequired();
            builder.Property(s=>s.Priority).HasColumnName("Priority");
            builder.Property(s=>s.Visibility).HasColumnName("Visibility");
        }
    }
}
