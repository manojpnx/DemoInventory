using DemoInventory.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoInventory.Application.Interfaces
{
    public interface IProductService
    {
        ProductViewModel GetProducts();
    }
}
