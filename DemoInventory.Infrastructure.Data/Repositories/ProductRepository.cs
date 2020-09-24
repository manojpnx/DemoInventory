using DemoInventory.Domain.Entities;
using DemoInventory.Domain.Interfaces;
using DemoInventory.Infrastructure.Data.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoInventory.Infrastructure.Data.Repositories
{
    public class ProductRepository : IProductRepository
    {
        public InventoryDbContext _context;

        public ProductRepository(InventoryDbContext context)
        {
            _context = context;
        }
        public IEnumerable<Product> GetProducts()
        {
            return _context.Products;
        }
    }
}
