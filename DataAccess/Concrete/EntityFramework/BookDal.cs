using Core.Concrete.EntityRepository;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class BookDal : EfEntityRepository<Book, DatabaseContext>, IBookDal
    {
        public List<BookDetailDto> GetBookDetail(Expression<Func<BookDetailDto,bool>> filter = null)
        {
            using(DatabaseContext context = new DatabaseContext())
            {
                var result = from book in context.Books
                             join author in context.Authors on book.AuthorId equals author.Id
                             join category in context.Categories on book.CategoryId equals category.Id
                             select new BookDetailDto
                             {
                                 BookId = book.Id,
                                 AuthorName = author.Name,
                                 BookName = book.Name,
                                 CategoryName = category.Name,
                                 NumberOfPages = book.NumberOfPages
                             };
                if(filter == null)
                {
                    return result.ToList();
                }
                else
                {
                    return result.Where(filter).ToList();
                }
            }
        }
    }
}
