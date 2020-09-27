
using DemoInventory.Application.Interfaces;
using DemoInventory.Application.ViewModels;
using DemoInventory.Domain.Entities;
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

        public IActionResult Create()
        {
            return View("Create");
        }

        [HttpPost]
        public IActionResult CreateProduct(ProductViewModel input)
        {
            _productService.Create(input.Product);

            return RedirectToAction("Index", "Product");

        }

        public ActionResult Edit(int id)
        {
            ProductViewModel model = _productService.GetProduct(id);
            return View("Edit", model);
        }

        public IActionResult Update(ProductViewModel input)
        {
            _productService.Update(input.Product);

            return RedirectToAction("Index", "Product");
        }

        public IActionResult Delete(long id)
        {
            _productService.Delete(id);

            return RedirectToAction("Index", "Product");
        }

    }

}