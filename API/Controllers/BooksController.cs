using Business.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        IBookService _bookService;
        public BooksController(IBookService bookService)
        {
            _bookService = bookService;
        }

        [HttpPost]
        public IActionResult Add(Book book)
        {
            var result = _bookService.Add(book);
            if (result.Success)
                return Ok(result);
            else
                return BadRequest(result.Message);
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _bookService.GetAll();
            if (result.Success)
                return Ok(result);
            else
                return BadRequest(result.Message);
        }

        [HttpGet("getbookdetails")]
        public IActionResult GetBookDetails()
        {
            var result = _bookService.GetBookDetails();
            if (result.Success)
                return Ok(result);
            else
                return BadRequest(result.Message);
        }

        [HttpPut]
        public IActionResult Update(Book book)
        {
            var result = _bookService.Update(book);
            if (result.Success)
                return Ok(result);
            else
                return BadRequest(result.Message);
        }

        [HttpDelete("id")]
        public IActionResult DeleteById(int id)
        {
            var deletedEntity = _bookService.GetById(id);
            var result = _bookService.DeleteById(id);
            if (result.Success)
                return Ok(result);
            else
                return BadRequest(result.Message);
        }

        [HttpDelete("name")]
        public IActionResult DeleteById(string name)
        {
            var deletedEntity = _bookService.GetByName(name);
            var result = _bookService.DeleteByName(name);
            if (result.Success)
                return Ok(result);
            else
                return BadRequest(result.Message);
        }
    }
}
