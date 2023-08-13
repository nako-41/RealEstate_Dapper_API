using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealEstate_Dapper_API.Repositories.CategoryRepository;
using RealEstate_Dapper_API.Repositories.ProductRepository;

namespace RealEstate_Dapper_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductRepository _productRepository;

        public ProductsController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }


        [HttpGet]
        public async Task<ActionResult> ProductList()
        {

            var values = await _productRepository.GetAllProductAsync();
            return Ok(values);

        }
        [HttpGet("ProductListWithCategory")]
        public async Task<ActionResult> ProductListWithCategory()
        {

            var values = await _productRepository.GetAllProductWithCategory();
            return Ok(values);

        }
    }
}
