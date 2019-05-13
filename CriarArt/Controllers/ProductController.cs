using System.Linq;
using System.Threading.Tasks;
using CriarArt.Context;
using CriarArt.Dto;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CriarArt.Controllers
{
    [Route("api/v1/products")]
    public class ProductController : Controller
    {
        private readonly OracleContext context;

        public ProductController(OracleContext context)
        {
            this.context = context;
        }

        public async Task<IActionResult> Get()
        {
            var products = await context.Products.ToListAsync();

            return Ok(products.Select(t => new ProductListDto(t)));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var product = await context.Products.FindAsync(id);

            if (product == null) return NotFound(id);

            return Ok(new ProductDetailDto(product));
        }
    }
}
