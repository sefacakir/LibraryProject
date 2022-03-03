using Core.Abstract;
using Core.Concrete.EntityRepository;
using Entities.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Business.Abstract
{
    public interface IBookService
    {
        public void Add(Book entity);
        public void DeleteById(int id);
        public void DeleteByName(string name);
        public void Update(Book entity);
        public Book GetById(int id);
        public Book GetByName(string name);
        public List<Book> GetAll();
        public List<BookDetailDto> GetBookDetails(Expression<Func<Book,bool>> filter = null);

    }
}
