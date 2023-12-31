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
    public class AccountCertificateConfiguration : IEntityTypeConfiguration<AccountCertificate>
    {
        public void Configure(EntityTypeBuilder<AccountCertificate> builder)
        {
            builder.ToTable("AccountCertificates").HasKey(e => e.Id);
            builder.Property(e => e.Id).HasColumnName("Id").IsRequired();
            builder.Property(e => e.AccountId).HasColumnName("AccountId").IsRequired();
            builder.Property(e => e.Name).HasColumnName("Name").IsRequired();

            builder.HasIndex(indexExpression: e => e.AccountId, name: "FK_AccountCertificates_Accounts");
            //one to many
            builder.HasQueryFilter(e => !e.DeletedDate.HasValue);
        }
    }
}
