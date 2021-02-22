using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NLayerStudying.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace NLayerStudying.Data.Seeds
{
    public class ProductSeed : IEntityTypeConfiguration<Products>
    {
        private readonly int[] _ids;
        public ProductSeed(int[] ids)
        {
            _ids = ids;
        }
        public void Configure(EntityTypeBuilder<Products> builder)
        {
            builder.HasData(
                new Products
                {
                    Id=1,
                    Name="Pilot Kalem",
                    Price=12.5m,
                    Stock=200,
                    CategoryId=_ids[0]
                },
                new Products
                {
                    Id = 2,
                    Name = "Kurşun Kalem",
                    Price = 12.5m,
                    Stock = 200,
                    CategoryId = _ids[0]
                },
                new Products
                {
                    Id = 3,
                    Name = "Tükenmez Kalem",
                    Price = 12.5m,
                    Stock = 200,
                    CategoryId = _ids[0]
                },
                new Products
                {
                    Id = 4,
                    Name = "Küçük Boy Defter",
                    Price = 12.5m,
                    Stock = 200,
                    CategoryId = _ids[1]
                }
                );
        }
    }
}
