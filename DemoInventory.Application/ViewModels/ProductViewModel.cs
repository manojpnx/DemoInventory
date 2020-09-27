using DemoInventory.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoInventory.Application.ViewModels
{
    public class ProductViewModel
    {
        public IEnumerable<Product> Products { get; set; }

        public Product Product { get; set; }
    }
}
