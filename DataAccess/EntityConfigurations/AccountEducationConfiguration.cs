﻿using Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.EntityConfigurations
{
    public class AccountEducationConfiguration:IEntityTypeConfiguration<AccountEducation>
    {
        public void Configure(EntityTypeBuilder<AccountEducation> builder)
        {
            builder.ToTable("AccountEducations").HasKey(a=>a.Id);
            builder.Property(a=>a.Id).HasColumnName("Id").IsRequired();
            builder.Property(a => a.AccountId).HasColumnName("AccountId").IsRequired();
            builder.Property(a => a.StartYear).HasColumnName("StartYear"); 
            builder.Property(a => a.GraduationYear).HasColumnName("GraduationYear");
            builder.Property(a => a.IsGraduated).HasColumnName("IsGraduated");
            builder.HasQueryFilter(e => !e.DeletedDate.HasValue);

            builder.HasOne(a => a.Account).WithMany(account => account.AccountEducations).HasForeignKey(a => a.AccountId).IsRequired().OnDelete(DeleteBehavior.NoAction);

        }
    }
}
