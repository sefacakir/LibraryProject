using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Business.Abstract
{
    public interface ICategoryService
    {
        public IResult Add(Category category);
        public IResult DeleteById(int id);
        public IResult DeleteByName(string name);
        public IDataResult<Category> GetById(int id);
        public IDataResult<Category> GetByName(string name);
        public IDataResult<Category> Update(Category category);
        public IDataResult<List<Category>> GetAll();
    }
}
