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
    [ApiController]
    public class AuthorsController : ControllerBase
    {
        IAuthorService _authorService;
        public AuthorsController(IAuthorService authorService)
        {
            _authorService = authorService;
        }

        [HttpGet("getall")]
        public List<Author> GetAll()
        {
            return _authorService.GetAll();
        }

        [HttpPost]
        public Author Add(Author author)
        {
            _authorService.Add(author);
            return author;
        }

        [HttpDelete("id")]
        public void DeleteById(int id)
        {
            _authorService.DeleteById(id);
        }

        [HttpDelete("name")]
        public void DeleteByName(string name)
        {
            _authorService.DeleteByName(name);
        }

        [HttpPut]
        public void Update(Author author)
        {
            _authorService.Update(author);
        }
    }
}
