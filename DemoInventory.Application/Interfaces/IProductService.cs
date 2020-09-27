using DemoInventory.Application.ViewModels;
using DemoInventory.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DemoInventory.Application.Interfaces
{
    public interface IProductService
    {
        ProductViewModel GetProducts();

        bool Create(Product product);
        ProductViewModel GetProduct(long id);
        bool Update(Product product);
        bool Delete(long id);
    }
}
