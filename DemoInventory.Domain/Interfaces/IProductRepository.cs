using DemoInventory.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoInventory.Domain.Interfaces
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetProducts();
    }
}
