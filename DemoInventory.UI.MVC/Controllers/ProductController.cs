using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DemoInventory.Application.Interfaces;
using DemoInventory.Application.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DemoInventory.UI.MVC.Controllers
{
    public class ProductController : Controller
    {
        private IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [Authorize]
        public IActionResult Index()
        {
            ProductViewModel model = _productService.GetProducts();
            return View(model);
        }
    }
}