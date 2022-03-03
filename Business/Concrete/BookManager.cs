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
        private readonly IBookDal _storyDal;
        public BookManager(IBookDal story)
        {
            _storyDal = story;
        }
        public void Add(Book story)
        {
            _storyDal.Add(story);
        }

        public void DeleteById(int id)
        {
            _storyDal.DeleteById(id);
        }

        public void DeleteByName(string name)
        {
            var deletedEntity = _storyDal.Get(c => c.Name.ToLower() == name.ToLower());
            _storyDal.DeleteById(deletedEntity.Id);
        }

        public List<Book> GetAll()
        {
            var stories = _storyDal.GetAll();
            return stories;
        }

        public List<BookDetailDto> GetBookDetails(Expression<Func<Book, bool>> filter = null)
        {
            return _storyDal.GetBookDetail();
        }

        public Book GetById(int id)
        {
            return _storyDal.Get(c => c.Id == id);
        }

        public Book GetByName(string name)
        {
            return _storyDal.Get(c => c.Name.ToLower() == name.ToLower());
        }

        public void Update(Book entity)
        {
            _storyDal.Update(entity);
        }
    }
}
