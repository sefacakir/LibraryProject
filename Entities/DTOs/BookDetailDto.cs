using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class BookDetailDto : IDto
    {
        public int BookId { get; set; }
        public string BookName { get; set; }
        public string AuthorName { get; set; }
        public string CategoryName { get; set; }
        public int NumberOfPages { get; set; }

    }
}
