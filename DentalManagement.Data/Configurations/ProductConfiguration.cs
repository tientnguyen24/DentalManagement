using DentalManagement.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DentalManagement.Data.Configurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("Products");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.Name).IsRequired(true).HasMaxLength(100);
            builder.Property(x => x.UnitPrice).IsRequired(true).HasMaxLength(100);
            builder.Property(x => x.CreatedDate).HasDefaultValue(DateTime.Now);
            builder.Property(x => x.CreatedBy).HasMaxLength(100);
            builder.Property(x => x.ModifiedDate).HasDefaultValue(DateTime.Now);
            builder.Property(x => x.ModifiedBy).HasMaxLength(100);
            builder.HasOne(x => x.ProductCategory).WithMany(x => x.Products).HasForeignKey(x => x.ProductCategoryId);
        }
    }
}
