using DentalManagement.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DentalManagement.Data.Configurations
{
    public class AccountConfiguration : IEntityTypeConfiguration<Account>
    {
        public void Configure(EntityTypeBuilder<Account> builder)
        {
            builder.ToTable("Accounts");
            builder.HasKey(x => x.UserName);
            builder.Property(x => x.UserName).IsRequired(true).HasMaxLength(50).IsUnicode(false);
            builder.Property(x => x.Password).IsRequired(true).HasMaxLength(50).IsUnicode(false);
            builder.Property(x => x.CreatedDate).HasDefaultValue(DateTime.Now);
            builder.Property(x => x.CreatedBy).IsRequired(false).HasMaxLength(100);
            builder.Property(x => x.ModifiedDate).HasDefaultValue(DateTime.Now);
            builder.Property(x => x.ModifiedBy).IsRequired(false).HasMaxLength(100);
            builder.Property(x => x.Type).IsRequired(true);
        }
    }
}
