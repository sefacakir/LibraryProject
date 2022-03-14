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
        public Book Add(Book book)
        {
            _bookService.Add(book);
            return book;
        }

        [HttpGet("getall")]
        public List<Book> GetAll()
        {
            return _bookService.GetAll();
        }

        [HttpGet("getbookdetails")]
        public List<BookDetailDto> GetBookDetails()
        {
            return _bookService.GetBookDetails();
        }

        [HttpPut]
        public Book Update(Book book)
        {
            _bookService.Update(book);
            return book;
        }

        [HttpDelete("id")]
        public Book DeleteById(int id)
        {
            var deletedEntity = _bookService.GetById(id);
            _bookService.DeleteById(id);
            return deletedEntity;
        }

        [HttpDelete("name")]
        public Book DeleteById(string name)
        {
            var deletedEntity = _bookService.GetByName(name);
            _bookService.DeleteByName(name);
            return deletedEntity;
        }
    }
}
