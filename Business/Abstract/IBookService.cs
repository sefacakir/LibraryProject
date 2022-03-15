using Core.Abstract;
using Core.Concrete.EntityRepository;
using Core.Utilities.Results;
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
        public IResult Add(Book entity);
        public IResult DeleteById(int id);
        public IResult DeleteByName(string name);
        public IResult Update(Book entity);
        public IDataResult<Book> GetById(int id);
        public IDataResult<Book> GetByName(string name);
        public IDataResult<List<Book>> GetAll();
        public IDataResult<List<BookDetailDto>> GetBookDetails(Expression<Func<Book,bool>> filter = null);
        public IDataResult<List<Book>> GetAllByCategoryId(int id);
        public IDataResult<List<Book>> GetAllByAuthorId(int id);

    }
}
