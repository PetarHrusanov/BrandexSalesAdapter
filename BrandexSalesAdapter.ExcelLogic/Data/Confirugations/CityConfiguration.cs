﻿namespace BrandexSalesAdapter.ExcelLogic.Data.Confirugations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using BrandexSalesAdapter.ExcelLogic.Data.Models;

    internal class CityConfiguration : IEntityTypeConfiguration<City>
    {
        public void Configure(EntityTypeBuilder<City> builder)
        {
            builder
                .HasKey(c => c.Id);

            builder
                .Property(c => c.Name)
                .IsRequired();

        }
    }
}
