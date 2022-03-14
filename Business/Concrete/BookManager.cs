using Business.Abstract;
using Core.Abstract;
using Core.Concrete.EntityRepository;
using DataAccess.Abstract;
using Entities.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Business.Concrete
{
    public class BookManager : IBookService
    {
        private readonly IBookDal _bookDal;
        public BookManager(IBookDal book)
        {
            _bookDal = book;
        }
        public void Add(Book book)
        {
            _bookDal.Add(book);
        }

        public void DeleteById(int id)
        {
            var deletedBook = _bookDal.Get(book => book.Id == id);
            _bookDal.Delete(deletedBook);
        }

        public void DeleteByName(string name)
        {
            var deletedBook = _bookDal.Get(book => book.Name.ToLower() == name.ToLower());
            _bookDal.Delete(deletedBook);
        }

        public List<Book> GetAll()
        {
            return _bookDal.GetAll();
        }

        public List<BookDetailDto> GetBookDetails(Expression<Func<Book, bool>> filter = null)
        {
            return _bookDal.GetBookDetail();
        }

        public Book GetById(int id)
        {
            return _bookDal.Get(c => c.Id == id);
        }

        public Book GetByName(string name)
        {
            return _bookDal.Get(c => c.Name.ToLower() == name.ToLower());
        }

        public void Update(Book entity)
        {
            _bookDal.Update(entity);
        }
    }
}
