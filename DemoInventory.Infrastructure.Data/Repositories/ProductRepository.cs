using DemoInventory.Domain.Entities;
using DemoInventory.Domain.Interfaces;
using DemoInventory.Infrastructure.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
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

        public Product GetProduct(long id)
        {
            return _context.Products.Where(p => p.Id == id).FirstOrDefault();
        }

        public bool Create(Product product)
        {
            _context.Add(product);
            return _context.SaveChanges() > 0 ? true : false;
        }

        public bool Update(Product product)
        {
            var result = _context.Products.Update(product);
            return _context.SaveChanges() > 0 ? true : false;
        }

        public bool Delete(long id)
        {
            var product = _context.Products.Where(p => p.Id == id).FirstOrDefault();
            var result = _context.Products.Remove(product);
            return _context.SaveChanges() > 0 ? true : false;
        }
    }

}
