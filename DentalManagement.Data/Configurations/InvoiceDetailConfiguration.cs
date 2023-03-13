using DentalManagement.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DentalManagement.Data.Configurations
{
    class InvoiceDetailConfiguration : IEntityTypeConfiguration<InvoiceDetail>
    {
        public void Configure(EntityTypeBuilder<InvoiceDetail> builder)
        {
            builder.ToTable("InvoiceDetails");
            builder.HasKey(x => new { x.InvoiceId, x.ProductId });
            builder.Property(x => x.ItemAmount).HasMaxLength(100).HasColumnType("decimal(18,2)");
            builder.Property(x => x.ItemDiscountAmount).HasMaxLength(100).HasColumnType("decimal(18,2)");
            builder.Property(x => x.ItemDiscountPercent).HasMaxLength(100).HasColumnType("decimal(18,2)");
            builder.Property(x => x.Quantity).HasMaxLength(100).HasColumnType("decimal(18,2)");
            builder.HasOne(x => x.Invoice).WithMany(x => x.InvoiceDetails).HasForeignKey(x => x.InvoiceId);
            builder.HasOne(x => x.Product).WithMany(x => x.InvoiceDetails).HasForeignKey(x => x.ProductId);
        }
    }
}
