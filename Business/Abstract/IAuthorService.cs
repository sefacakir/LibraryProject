using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IAuthorService
    {
        public IResult Add(Author author);
        public IResult DeleteById(int id);
        public IResult DeleteByName(string name);
        public IDataResult<Author> Update(Author author);
        public IDataResult<Author> GetById(int id);
        public IDataResult<Author> GetByName(string name);
        public IDataResult<List<Author>> GetAll();
    }
}
