using Bernhoeft.Core.Queries;
using Bernhoeft.Domain.Entity;
using Bernhoeft.Infra.Context;
using Bernhoeft.Infra.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bernhoeft.Api.Controllers
{
    [Route("api/[controller]/v1")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductRepository _productRepository;
        private readonly ProductDbContext _dbContext;

        public ProductController(IProductRepository productRepository, ProductDbContext dbContext)
        {
            _productRepository = productRepository;
            _dbContext = dbContext;
        }

        [HttpGet]
        public IActionResult GetAllProduct([FromQuery] string filterDescription,
                                            [FromQuery] string filterCategory,
                                            [FromQuery] bool filterActive = false)
        {
            try
            {
               var productList =  _productRepository.GetAll(filterDescription, filterCategory, filterActive);


                return Ok(productList);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPost]
        public IActionResult CreateProduct([FromBody] Product prod)
        {
            try
            {
                _productRepository.CreateProduct(prod);
                return Created("", prod);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPut]
        public IActionResult UpdateProduct(Product prod)
        {
            try
            {
                _productRepository.UpdateProduct(prod);
                return Ok(_productRepository.FindById(prod.Id));
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
