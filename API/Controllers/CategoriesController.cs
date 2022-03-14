using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Controllers
{
    [Route("api/[controller]")]
    public class CategoriesController : Controller
    {
        ICategoryService _categoryService;
        public CategoriesController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpPost]
        public Category Add(Category category)
        {
            _categoryService.Add(category);
            return category;
        }

        [HttpPut]
        public Category Update(Category category)
        {
            _categoryService.Update(category);
            return category;
        }

        [HttpGet("getall")]
        public List<Category> GetAll()
        {
            return _categoryService.GetAll();
        }

        [HttpDelete("id")]
        public void Delete(int id)
        {
            _categoryService.DeleteById(id);
        }

        [HttpDelete("name")]
        public void Delete(string name)
        {
            _categoryService.DeleteByName(name);
        }
    }
}
