using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NLayerStudying.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace NLayerStudying.Data.Seeds
{
    public class CategorySeed : IEntityTypeConfiguration<Categories>
    {
        private readonly int[] _ids;

        public CategorySeed(int[] ids)
        {
            _ids = ids;
        }

        public void Configure(EntityTypeBuilder<Categories> builder)
        {
            builder.HasData(
                new Categories
                {
                    Id=_ids[0],
                    Name = "Kalem"
                },
                new Categories
                {
                    Id=_ids[1],
                    Name="Defter"
                }
                );
        }
    }
}
