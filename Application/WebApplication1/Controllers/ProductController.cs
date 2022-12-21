using Bernhoeft.Core.Queries;
using Bernhoeft.Domain.Entity;
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

        public ProductController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        [HttpGet]
        public IActionResult GetAllProduct([FromQuery] string filterDescription,
                                            [FromQuery] string filterCategory,
                                            [FromQuery] bool? filterActive)
        {
            try
            {
                return Ok(_productRepository.GetAll().ToList());
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

        [HttpDelete]
        public IActionResult DeleteProduct(int id)
        {
            try
            {
                var prod = _productRepository.FindById(id);

                _productRepository.DeleteProduct(prod);
                return Ok();
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
