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
    public class AccountSkillConfiguration : IEntityTypeConfiguration<AccountSkill>
    {
        public void Configure(EntityTypeBuilder<AccountSkill> builder)
        {
            builder.ToTable("AccountSkills").HasKey(ak => ak.Id);
            builder.Property(ak => ak.Id).HasColumnName("Id").IsRequired(); 
            builder.Property(ak => ak.AccountId).HasColumnName("AccountId").IsRequired(); 
            builder.Property(ak => ak.SkillId).HasColumnName("SkillId").IsRequired(); 
            //builder.HasIndex(indexExpression: ak => ak.AccountId, name: "FK_AccountSkills_Accounts");
            //builder.HasIndex(indexExpression: ak => ak.SkillId, name: "FK_AccountSkills_Skills");
            builder.HasQueryFilter(ak => !ak.DeletedDate.HasValue);
        }
    }
}
