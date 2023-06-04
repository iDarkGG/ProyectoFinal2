using Dependencias.Data;
using Dependencias.Dtos;
using Dependencias.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [Route("ApiTienda/[Controller]")]
    [ApiController]
    public class ProductsController : Controller
    {
        private readonly MainContext context;
        private readonly ILogger<ProductsController> logger;

        public ProductsController(MainContext context, ILogger<ProductsController> logger)
        {
            this.context = context;
            this.logger = logger;
        }

      
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<Product>>> getProducts()
        {
            logger.LogInformation("Get all Products");
            var lst = await context.Products.ToListAsync();
            return Ok(lst);
        }

        [HttpGet("{Id:int}",Name = "getProductById")]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<Product>> getProductById(int Id)
        {
            logger.LogInformation("Gets the Product from the specified id");

            if (Id == 0)
            {
                logger.LogError($"The product with id {Id} does not exists.");
                return BadRequest();
            }

            var product = await context.Products.FindAsync(Id);
            
            if(product is null)
            {
                logger.LogError($"Cannot find the Product with id: {Id}.");
                return NotFound();
            }

            return Ok(product);
        }

        [HttpGet("{Name}", Name = "getProductByName")]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<Product>> getProductByName(string Name)
        {
            logger.LogInformation("Gets the Product from the specified name");

            var product = await context.Products.FirstOrDefaultAsync(x => x.ProductName == Name);

            if (string.IsNullOrWhiteSpace(Name))
            {
                logger.LogError($"Cannot find the Product with the name: {Name}.");
                return NotFound();
            }

            return Ok(product);
        }

        [HttpPut("{id:int}", Name = "UpdateProduct")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult> UpdateProduct([FromBody] ProductUpdateDto Product,int id)
        {
            if (id == 0) return BadRequest(ModelState);

            if (Product is null) return BadRequest();

            var ProductToFind = await context.Products.FindAsync(id);

            if (ProductToFind is null)
            {
                logger.LogError($"Cannot find the Product.");
                return NotFound();
            }

            ProductToFind.ProductDescription = Product.ProductDescription;
            ProductToFind.ProductPrice = Product.ProductPrice;
            ProductToFind.ProductStock = Product.ProductStock;

            context.Entry(ProductToFind).State = EntityState.Modified;

            await context.SaveChangesAsync();

            return Ok();
        }

    }
}
