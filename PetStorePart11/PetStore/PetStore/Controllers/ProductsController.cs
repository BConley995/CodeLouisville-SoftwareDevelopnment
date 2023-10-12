using Microsoft.AspNetCore.Mvc;
using PetStore.Data;
using PetStore.Logic;

namespace PetStore.Controllers
{
    [ApiController]
    [Route("products")]
    public class ProductsController : ControllerBase
    {
        private IProductRepository _productRepository;

        public ProductsController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        [HttpGet("get-product/{id}")]
        public ActionResult<Product> GetProduct(int id)
        {
            var product = _productRepository.GetProductById(id);

            if (product is null)
            {
                return NotFound();
            }

            return Ok(product);
        }
    }
}
