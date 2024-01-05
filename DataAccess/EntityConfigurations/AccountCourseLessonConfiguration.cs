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
    public class AccountCourseLessonConfiguration : IEntityTypeConfiguration<AccountCourseLesson>
    {
        public void Configure(EntityTypeBuilder<AccountCourseLesson> builder)
        {
            builder.ToTable("AccountCourseLessons").HasKey(ac => ac.Id);
            builder.Property(ac => ac.Id).HasColumnName("Id").IsRequired();
            builder.Property(ac => ac.AccountId).HasColumnName("AccountId").IsRequired();
            builder.Property(ac => ac.LessonId).HasColumnName("LessonId").IsRequired();
            builder.Property(ac => ac.LessonStatusId).HasColumnName("LessonStatusId").IsRequired();
            //builder.Property(ac => ac.Like).HasColumnName("Like");
            builder.Property(ac => ac.IsActive).HasColumnName("IsActive");
            //builder.HasIndex(indexExpression: ac => ac.AccountId, name: "FK_AccountCourseLessons_Accounts");
            //builder.HasIndex(indexExpression: ac => ac.LessonId, name: "FK_AccountCourseLessons_Lessons");
            //builder.HasIndex(indexExpression: ac => ac.LessonStatusId, name: "FK_AccountCourseLessons_LessonStates");

            builder.HasQueryFilter(ac => !ac.DeletedDate.HasValue);
            //BAĞLANTILAR KURULACAK!!!
        }
    }
}
