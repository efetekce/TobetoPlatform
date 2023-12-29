using Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.EntityConfigurations
{
    public class SurveyConfiguration : IEntityTypeConfiguration<Survey>
    {
        public void Configure(EntityTypeBuilder<Survey>builder)
        {
            builder.ToTable("Surveys").HasKey(s => s.Id);
            builder.Property(s => s.Id).HasColumnName("Id").IsRequired();
            builder.Property(s => s.OrganizationId).HasColumnName("OrganizationId").IsRequired();
            builder.Property(s => s.SurveyTypeId).HasColumnName("SurveyTypeId").IsRequired();
            builder.Property(s => s.Title).HasColumnName("Title");
            builder.Property(s => s.Content).HasColumnName("Content");
            builder.Property(s => s.Link).HasColumnName("Link");
            builder.Property(s => s.PublishedDate).HasColumnName("PublishedDate");
            builder.Property(s => s.Priority).HasColumnName("Priority");
            builder.Property(s => s.Visibility).HasColumnName("Visibility");
            builder.HasOne(s => s.Organization)
                .WithMany()
                .HasForeignKey(s => s.OrganizationId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(s => s.SurveyTypes)
                .WithMany()
                .HasForeignKey(s => s.SurveyTypeId)
                .OnDelete(DeleteBehavior.Cascade);
            builder.HasQueryFilter(s => !s.DeletedDate.HasValue);
        }
    }
}
