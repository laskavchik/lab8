using System;
using System.Collections.Generic;
using System.Text;
using DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DAL.EntitiesConfigurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder
                .Property(prop => prop.Price)
                .IsRequired();
            builder
                .Property(prop => prop.Id)
                .IsRequired();

        }
    }
}
