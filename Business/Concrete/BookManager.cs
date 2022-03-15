using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using Business.Messages;

namespace Business.Concrete
{
    public class BookManager : IBookService
    {
        private readonly IBookDal _bookDal;
        public BookManager(IBookDal book)
        {
            _bookDal = book;
        }
        public IResult Add(Book book)
        {
            _bookDal.Add(book);
            return new SuccessResult(Message.SuccessAdded);
        }

        public IResult DeleteById(int id)
        {
            var deletedBook = _bookDal.Get(book => book.Id == id);
            _bookDal.Delete(deletedBook);
            return new SuccessResult(Message.SuccessDeleted);
        }

        public IResult DeleteByName(string name)
        {
            var deletedBook = _bookDal.Get(book => book.Name.ToLower() == name.ToLower());
            _bookDal.Delete(deletedBook);
            return new SuccessResult(Message.SuccessDeleted);
        }

        public IDataResult<List<Book>> GetAll()
        {
            var result = _bookDal.GetAll();
            return new SuccessDataResult<List<Book>>(result, Message.Completed);
        }

        public IDataResult<List<BookDetailDto>> GetBookDetails(Expression<Func<Book, bool>> filter = null)
        {
            var result = _bookDal.GetBookDetail();
            return new SuccessDataResult<List<BookDetailDto>>(result, Message.Completed);
        }

        public IDataResult<Book> GetById(int id)
        {
            var result = _bookDal.Get(c => c.Id == id);
            return new SuccessDataResult<Book>(result, Message.Completed);
        }

        public IDataResult<Book> GetByName(string name)
        {
             var result = _bookDal.Get(c => c.Name.ToLower() == name.ToLower());
            return new SuccessDataResult<Book>(result, Message.Completed);
        }

        public IResult Update(Book entity)
        {
            var result = _bookDal.Update(entity);
            return new SuccessResult(Message.SuccessUpdated);
        }
    }
}
