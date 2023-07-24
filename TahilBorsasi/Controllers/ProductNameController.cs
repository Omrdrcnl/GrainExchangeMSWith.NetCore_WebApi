using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TahilBorsasi.Model;
using TahilBorsasi.Repository;

namespace TahilBorsasi.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductNameController : ControllerBase
    {
        private ProductNameRepository repository;
        public ProductNameController(ProductNameRepository repository)
        {
            this.repository = repository;
        }

        public ProductNameRepository Repository { get => repository; set => repository = value; }

        [HttpGet("ProductList")]
        public dynamic ProductList() {
            List<ProductName> item = Repository.FindAll().ToList<ProductName>();
            return new
            {
                success = true,
                data = item
            };
        }
    }
}
