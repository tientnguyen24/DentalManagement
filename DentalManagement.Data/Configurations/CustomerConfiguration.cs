using DentalManagement.Data.Enums;
using DentalManagement.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DentalManagement.Data.Configurations
{
    public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.ToTable("Customers");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.FullName).IsRequired(true).HasMaxLength(100);
            builder.Property(x => x.Gender).IsRequired(true);
            builder.Property(x => x.BirthDay);
            builder.Property(x => x.Address).IsRequired(true).HasMaxLength(200);
            builder.Property(x => x.PhoneNumber).IsRequired(true).HasMaxLength(50);
            builder.Property(x => x.EmailAddress).HasMaxLength(100).IsUnicode(false);
            builder.Property(x => x.IdentifyCard).HasMaxLength(100);
            builder.Property(x => x.Status).HasDefaultValue(Status.Active);
            builder.Property(x => x.Description).HasMaxLength(200);
            builder.Property(x => x.CreatedDate).HasDefaultValue(DateTime.Now);
            builder.Property(x => x.CreatedBy).HasMaxLength(100);
            builder.Property(x => x.ModifiedDate).IsRequired(false);
            builder.Property(x => x.ModifiedBy).HasMaxLength(100);
        }
    }
}
