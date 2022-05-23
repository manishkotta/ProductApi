using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProductApi.Models;
using ProductApi.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {

        private readonly OfferService _offerService;
        public ProductController(OfferService offerService)
        {
            this._offerService = offerService;
        }

        [HttpGet]
        public IEnumerable<Offer> Get()
        {
            return this._offerService.GetTodaysOffers();
        }

        [HttpGet("GetLowestPriceProducts")]
        public IEnumerable<Product> GetLowestPriceProducts()
        {
            var response = this._offerService.GetAllProducts();

            return response.OrderBy(o => o.Price).Take(3).AsEnumerable();
        }

        [HttpGet("GetSecondLowestPriceProduct")]
        public Product GetSecondLowestPriceProduct()
        {
            var response = this._offerService.GetAllProducts();

            return response.FirstOrDefault(f => f.Price > response.Min(m => m.Price));
        }

        [HttpPost("AddProduct")]
        public IActionResult Add([FromBody] Product product)
        {
            if(product == null)
            {
                return BadRequest();
            }
            this._offerService.AddProduct(product);
            return Ok();
        }


    }
}
