﻿using Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.EntityConfigurations
{
    public class AccountConfiguration : IEntityTypeConfiguration<Account>
    {
        public void Configure(EntityTypeBuilder<Account> builder)
        {
            builder.ToTable("Accounts").HasKey(b => b.Id);
            builder.Property(a => a.AdressId).HasColumnName("AdressId");
            builder.Property(a => a.FirstName).HasColumnName("FirstName").IsRequired();
            builder.Property(a => a.LastName).HasColumnName("LastName").IsRequired();
            builder.Property(a => a.NationalId).HasColumnName("NationalId").IsRequired();
            builder.Property(a => a.BirthDate).HasColumnName("BirthDate").IsRequired();
            builder.Property(a => a.PhoneNumber).HasColumnName("PhoneNumber").IsRequired();
            builder.Property(a => a.Status).HasColumnName("Status").IsRequired();
            builder.HasIndex(indexExpression: a => a.NationalId, name: "UK_Accounts_NationalId").IsUnique();


          //  builder.HasMany(a => a.AccountSocialMedias);
            builder.HasMany(a => a.AccountEducations);
            builder.HasMany(a => a.AccountForeignLanguages);
            builder.HasMany(a => a.AccountCourses);
            builder.HasMany(a => a.AccountCertificates);
            builder.HasMany(a => a.AccountCoursesLessons);
            builder.HasMany(a => a.AccountTestResults);
            builder.HasMany(a => a.AccountApplications);
            builder.HasOne(a => a.Address);
            //adress classı accountadress olmalı ve bu tablo accountıd içermeli

            builder.HasQueryFilter(a => !a.DeletedDate.HasValue);
        }
    }
}
