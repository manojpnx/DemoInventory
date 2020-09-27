using DemoInventory.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoInventory.Infrastructure.Data.Context
{
    public class InventoryDbContext : DbContext
    {
        public InventoryDbContext(DbContextOptions options) : base(options) { }
        public DbSet<Product> Products { get; set; }

        //For data seed
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Product>().HasData(
        //        new Product { Id = 10, Name = "iPhone X", Sku ="P-000001",Description ="Apple iPhone X",Quantity = 500,ReorderLevel = 10,Price = 1000 },
        //        new Product { Id = 11, Name = "Pixel 4", Sku = "P-000002", Description = "Google Pixel 4", Quantity = 400, ReorderLevel = 20, Price = 900},
        //        new Product { Id = 12, Name = "Galaxy A30", Sku = "P-000003", Description = "SAmsung Galaxy A30", Quantity = 800, ReorderLevel = 30, Price = 700 } );
        //}
    }
}
