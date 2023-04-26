using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using reventTest.Model;
using reventTest.Services;

namespace reventTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet("getProducts")]
        public ActionResult GetProducts() {
            var products = _productService.GetProducts();
            return Ok(products);
        }

        [HttpPost("addproduct")]
        public ActionResult AddProduct(Products product)
        {
            var products = _productService.AddProduct(product);
            return Ok(products);
        }

        [HttpDelete("deleteproduct/{Id}")]
        public ActionResult DeleteProduct(string Id)
        {
            var products = _productService.RemoveProduct(Id);
            return Ok(products);
        }
    }
}
