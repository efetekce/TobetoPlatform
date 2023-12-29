using Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.EntityConfigurations
{
    public class SurveyTypeConfiguration : IEntityTypeConfiguration<SurveyType>
    {
        public void Configure(EntityTypeBuilder<SurveyType> builder)
        {
            builder.ToTable("SurveyTypes").HasKey(st => st.Id);
            builder.Property(st => st.Id).HasColumnName("Id").IsRequired();
            builder.Property(st => st.Name).HasColumnName("Name");
            builder.Property(st => st.Priority).HasColumnName("Priority");
            builder.Property(st => st.Visibility).HasColumnName("Visibility");

            builder
                .HasMany(st => st.Surveys)
                .WithOne(s => s.SurveyTypes)
                .HasForeignKey(s => s.SurveyTypeId)
                .OnDelete(DeleteBehavior.Restrict);
            builder.HasQueryFilter(st => !st.DeletedDate.HasValue);
        }
    }
}
