using DemoInventory.Application.Interfaces;
using DemoInventory.Application.ViewModels;
using DemoInventory.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoInventory.Application.Services
{
    public class ProductService : IProductService
    {
        public IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        public ProductViewModel GetProducts()
        {
            return new ProductViewModel()
            {
                Products = _productRepository.GetProducts()
            };
        }
    }
}
