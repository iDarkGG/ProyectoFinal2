using API.Dtos;
using API.Repositorio;
using AutoMapper;
using Dependencias.Model;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [Route("ApiTienda/[Controller]")]
    [ApiController]
    public class ProductsController : Controller
    {
        private readonly IProductRepository context;
        private readonly ILogger<ProductsController> logger;
        private readonly IMapper mapper;


        public ProductsController(IProductRepository context, ILogger<ProductsController> logger, IMapper mapper)
        {
            this.context = context;
            this.logger = logger;
            this.mapper = mapper;
        }


        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<ProductDto>>> getProducts()
        {
            logger.LogInformation("Get all Products");
            var lst = await context.GetAll();
            return Ok(mapper.Map<ProductDto>(lst));
        }

        [HttpGet("{Id:int}", Name = "getProductById")]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<ProductDto>> getProductById(int Id)
        {
            logger.LogInformation("Gets the Product from the specified id");

            if (Id == 0)
            {
                logger.LogError($"The product with id {Id} does not exists.");
                return BadRequest();
            }

            var product = await context.Get(x => x.ProductId == Id);

            if (product is null)
            {
                logger.LogError($"Cannot find the Product with id: {Id}.");
                return NotFound();
            }

            return Ok(mapper.Map<ProductDto>(product));
        }

        [HttpGet("{Name}", Name = "getProductByName")]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<ProductDto>> getProductByName(string Name)
        {
            logger.LogInformation("Gets the Product from the specified name");

            var product = await context.Get(x => x.ProductName == Name);

            if (string.IsNullOrWhiteSpace(Name))
            {
                logger.LogError($"Cannot find the Product with the name: {Name}.");
                return NotFound();
            }

            return Ok(product);
        }

        [HttpPut("{id:int}", Name = "UpdateProduct")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult> UpdateProduct([FromBody] ProductUpdateDto Product, int id)
        {
            if (id == 0) return BadRequest(ModelState);

            if (Product is null) return BadRequest();

            var ProductToFind = await context.Get(x => x.ProductId == id); 

            if (ProductToFind is null)
            {
                logger.LogError($"Cannot find the Product.");
                return NotFound();
            }

            ProductToFind.ProductDescription = Product.ProductDescription;
            ProductToFind.ProductPrice = Product.ProductPrice;
            ProductToFind.ProductStock = Product.ProductStock;

            await context.GuardarCambios();

            return Ok();
        }

        [HttpPatch("{id:int}")]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult> UpdatePatch(int id, JsonPatchDocument<ProductUpdateDto> json)
        {
            if (json is null || id == 0) return BadRequest();

            var producto = await context.Get(x => x.ProductId == id,true);

            if(producto is null) return NotFound();

            var productTemp = mapper.Map<ProductUpdateDto>(producto);

            if (!ModelState.IsValid) return BadRequest();

            json.ApplyTo(productTemp,ModelState);


            context.Update(mapper.Map<Product>(productTemp));

            return NoContent();
        }

    }
}
