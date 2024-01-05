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
    public class AccountCourseConfiguration : IEntityTypeConfiguration<AccountCourse>
    {
        public void Configure(EntityTypeBuilder<AccountCourse> builder)
        {
            builder.ToTable("AccountCourses").HasKey(e => e.Id);
            builder.Property(e => e.Id).HasColumnName("Id").IsRequired();
            builder.Property(e => e.AccountId).HasColumnName("AccountId").IsRequired();
            builder.Property(e => e.CourseId).HasColumnName("CourseId").IsRequired();

            //builder.HasIndex(indexExpression: e => e.AccountId, name: "FK_AccountCourses_Accounts");
            //one to many
            builder.HasQueryFilter(e => !e.DeletedDate.HasValue);
        }
    }
}
