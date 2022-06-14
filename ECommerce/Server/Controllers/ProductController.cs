using Microsoft.AspNetCore.Mvc;

namespace ECommerce.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
        [HttpGet]
        public ActionResult<Product> GetProduct()
        {
            IEnumerable<Product> products = new List<Product> {
                new Product
                {
                    Id = 1,
                    Name = "Hello world",
                    Description = "A product"
                },
                new Product
                {
                    Id = 2,
                    Name = "Hello world 2",
                    Description = "Second Hello world"
                }
        };    


            return Ok(products);
        }

    }
}
