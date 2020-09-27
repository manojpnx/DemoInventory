using DemoInventory.Application.Interfaces;
using DemoInventory.Application.ViewModels;
using DemoInventory.Domain.Entities;
using DemoInventory.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
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

        public bool Create(Product product) 
        {
           return _productRepository.Create(product);
        }

        public ProductViewModel GetProduct(long id)
        {
            return new ProductViewModel()
            {
                Product = _productRepository.GetProduct(id)
            };
        }

        public bool Update(Product product)
        {
            return _productRepository.Update(product);
        }
        public bool Delete(long id)
        {
            return _productRepository.Delete(id);
        }
    }
}
