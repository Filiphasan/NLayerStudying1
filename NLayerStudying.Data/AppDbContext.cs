using Microsoft.EntityFrameworkCore;
using NLayerStudying.Core.Models;
using NLayerStudying.Data.Configurations;
using NLayerStudying.Data.Seeds;
using System;
using System.Collections.Generic;
using System.Text;

namespace NLayerStudying.Data
{
    public class  AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {

        }
        public DbSet<Products> Products { get; set; }
        public DbSet<Categories> Categories { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ProductConfiguration());
            modelBuilder.ApplyConfiguration(new CategoryConfiguration());
            modelBuilder.ApplyConfiguration(new ProductSeed(new int[] { 1,2}));
            modelBuilder.ApplyConfiguration(new CategorySeed(new int[] { 1, 2 }));
        }
    }
}
