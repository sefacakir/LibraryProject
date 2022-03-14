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
        public IDataResult<List<Author>> GetAll()
        {
            var result = _authorService.GetAll();
            return new SuccessDataResult<List<Author>>(result.Data, result.Message);
        }

        [HttpPost]
        public IResult Add(Author author)
        {
            var result = _authorService.Add(author);
            return new SuccessResult(result.Message);
        }

        [HttpDelete("id")]
        public IResult DeleteById(int id)
        {
            var result = _authorService.DeleteById(id);
            return new SuccessResult(result.Message);
        }

        [HttpDelete("name")]
        public IResult DeleteByName(string name)
        {
            var result = _authorService.DeleteByName(name);
            return new SuccessResult(result.Message);
        }

        [HttpPut]
        public IDataResult<Author> Update(Author author)
        {
            var result = _authorService.Update(author);
            return new SuccessDataResult<Author>(result.Data, result.Message);
        }
    }
}
