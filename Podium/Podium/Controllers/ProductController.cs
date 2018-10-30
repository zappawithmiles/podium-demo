using Microsoft.AspNetCore.Mvc;
using Podium.Models;
using Podium.ViewModels;
using System.Collections.Generic;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Podium.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductRepository _productRepository;
        private readonly IApplicantRepository _applicantRepository;

        public ProductController(IProductRepository productRepository, IApplicantRepository applicantRepository)
        {
            _productRepository = productRepository;
            _applicantRepository = applicantRepository;
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            ProductsViewModel allProductsViewModel = new ProductsViewModel();
            allProductsViewModel.Products = _productRepository.GetAllProducts();
            return View(allProductsViewModel);
        }

        [HttpGet]
        public IEnumerable<Product> GetAllProducts()
        {
            return _productRepository.GetAllProducts();
        }

        [HttpGet]
        public IActionResult GetAvailableProducts(int applicantId, double propertyValue, double depositAmount)
        {

            var products = _productRepository.GetAvailableProducts(applicantId, propertyValue, depositAmount);

            if (HttpContext.Request.ContentType == "application/json")
            {
                return Json(products);
            }
            else
            {
                AvailableProductsViewModel availableProductsViewModel = new AvailableProductsViewModel();
                availableProductsViewModel.Products = products;
                availableProductsViewModel.FirstName = _applicantRepository.GetApplicantFirstName(applicantId);

                return View("AvailableProducts", availableProductsViewModel);
            }
        }
    }
}
