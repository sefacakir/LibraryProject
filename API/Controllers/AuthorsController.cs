using Business.Abstract;
using Core.Utilities.Results;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorsController : ControllerBase
    {
        IAuthorService _authorService;
        public AuthorsController(IAuthorService authorService)
        {
            _authorService = authorService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _authorService.GetAll();
            if (result.Success)
                return Ok(result);
            else
                return BadRequest(result.Message);
        }

        [HttpPost]
        public IActionResult Add(Author author)
        {
            var result = _authorService.Add(author);
            if (result.Success)
                return Ok(result);
            else
                return BadRequest(result.Message);

        }

        [HttpDelete("id")]
        public IActionResult DeleteById(int id)
        {
            var result = _authorService.DeleteById(id);
            if (result.Success)
                return Ok(result);
            else
                return BadRequest(result.Message);
        }

        [HttpDelete("name")]
        public IActionResult DeleteByName(string name)
        {
            var result = _authorService.DeleteByName(name);

            if (result.Success)
                return Ok(result);
            else
                return BadRequest(result.Message);
        }

        [HttpPut]
        public IActionResult Update(Author author)
        {
            var result = _authorService.Update(author);
            if (result.Success)
                return Ok(result);
            else
                return BadRequest(result.Message);
        }
    }
}
