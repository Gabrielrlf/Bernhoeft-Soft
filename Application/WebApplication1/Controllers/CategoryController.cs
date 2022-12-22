using Bernhoeft.Domain.Entity;
using Bernhoeft.Infra.Context;
using Bernhoeft.Infra.Interface;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bernhoeft.Api.Controllers
{
    [Route("api/[controller]/v1")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly ProductDbContext _dbContext;

        public CategoryController(ICategoryRepository categoryRepository, ProductDbContext dbContext)
        {
            _categoryRepository = categoryRepository;
            _dbContext = dbContext;
        }

        [HttpGet]
        public IActionResult GetAllCategory([FromQuery] string filterCategory,
                                     [FromQuery] bool filterActive = false)
        {
            try
            {
                var categoriesList = _dbContext.Categories
                           .Where(x => string.IsNullOrEmpty(filterCategory) || x.PropertyName.ToUpper() == filterCategory.ToUpper())
                           .Where(x => x.Situation == filterActive);


                return Ok(categoriesList.ToList());
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPost]
        public IActionResult CreateProduct([FromBody] Category category)
        {
            try
            {
                _categoryRepository.CreateProduct(category);
                return Created("", category);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPut]
        public IActionResult UpdateProduct(Category category)
        {
            try
            {
                _categoryRepository.UpdateCategory(category);
                return Ok(_categoryRepository.FindById(category.Id));
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
