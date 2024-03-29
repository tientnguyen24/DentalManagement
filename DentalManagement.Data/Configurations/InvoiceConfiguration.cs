﻿using DentalManagement.Data.Entities;
using DentalManagement.Data.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DentalManagement.Data.Configurations
{
    public class InvoiceConfiguration : IEntityTypeConfiguration<Invoice>
    {
        public void Configure(EntityTypeBuilder<Invoice> builder)
        {
            builder.ToTable("Invoices");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.CreatedDate).IsRequired(true);
            builder.Property(x => x.CreatedBy).IsRequired(true).HasMaxLength(100);
            builder.Property(x => x.TotalDiscountPercent).HasMaxLength(50).HasColumnType("decimal(18,2)");
            builder.Property(x => x.TotalDiscountAmount).HasMaxLength(100).HasColumnType("decimal(18,2)");
            builder.Property(x => x.TotalInvoiceAmount).HasMaxLength(100).HasColumnType("decimal(18,2)");
            builder.Property(x => x.ModifiedDate).IsRequired(false);
            builder.Property(x => x.ModifiedBy).HasMaxLength(100);
            builder.Property(x => x.Description).HasMaxLength(300);
            builder.HasOne(x => x.Customer).WithMany(x => x.Invoices).HasForeignKey(x => x.CustomerId);
            builder.Property(x => x.PaymentStatus).HasDefaultValue(PaymentStatus.Processing);
            builder.Property(x => x.PrepaymentAmount).HasMaxLength(100).HasColumnType("decimal(18,2)");
            builder.Property(x => x.RemainAmount).HasMaxLength(100).HasColumnType("decimal(18,2)");
        }
    }
}
