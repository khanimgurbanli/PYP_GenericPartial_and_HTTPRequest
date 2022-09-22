using Microsoft.AspNetCore.Mvc;
using PYP_GenericPartial_and_HTTPRequest.DTOs;
using PYP_GenericPartial_and_HTTPRequest.Services.Abstraction;

namespace PYP_GenericPartial_and_HTTPRequest.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IProductHttpClient _httpClient;

        public ProductsController(IProductHttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            ProductsData products = await _httpClient.GetProductsAsync();
            return View(products.Products);
        }

        [HttpGet]
        public async Task<IActionResult> Detail([FromRoute] int id)
        {
            Product product = await _httpClient.GetProductAsync(id);
            return View(product);
        }
    }
}
