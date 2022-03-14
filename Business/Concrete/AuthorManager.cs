using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Business.Messages;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class AuthorManager : IAuthorService
    {
        private readonly IAuthorDal _authorDal;
        public AuthorManager(IAuthorDal authorDal)
        {
            _authorDal = authorDal;
        }
        public IResult Add(Author author)
        {
            _authorDal.Add(author);
            return new SuccessResult(Message.SuccessAdded);
        }

        public IResult DeleteById(int id)
        {
            var deletedEntity = _authorDal.Get(author => author.Id == id);
            _authorDal.Delete(deletedEntity);
            return new SuccessResult(Message.SuccessDeleted);
        }

        public IResult DeleteByName(string name)
        {
            var deletedEntity = _authorDal.Get(author => author.Name.ToLower() == name.ToLower());
            _authorDal.Delete(deletedEntity);
            return new SuccessResult(Message.SuccessDeleted);
        }

        public IDataResult<List<Author>> GetAll()
        {
            var data = _authorDal.GetAll();
            return new SuccessDataResult<List<Author>>(data, Message.Completed);
        }

        public IDataResult<Author> GetById(int id)
        {
            var data = _authorDal.Get(c => c.Id == id);
            return new SuccessDataResult<Author>(data, Message.Completed);
        }

        public IDataResult<Author> GetByName(string name)
        {
            var data = _authorDal.Get(c => c.Name.ToLower() == name.ToLower());
            return new SuccessDataResult<Author>(data, Message.Completed);
        }

        public IDataResult<Author> Update(Author author)
        {
            var data = _authorDal.Update(author);
            return new SuccessDataResult<Author>(data, Message.Completed);
        }
    }
}
