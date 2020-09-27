using DemoInventory.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DemoInventory.Domain.Interfaces
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetProducts();
        bool Create(Product product);
        Product GetProduct(long id);
        bool Update(Product product);
        bool Delete(long id);

    }
}
