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
        public void Add(Book book)
        {
            Console.WriteLine("Buraya geldi ve çalışmakta.");
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
    }
}
