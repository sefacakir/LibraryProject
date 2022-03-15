using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using Business.Messages;
using System.Text;

namespace Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private readonly ICategoryDal _categoryDal;
        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }


        public IResult Add(Category category)
        {
            _categoryDal.Add(category);
            return new SuccessResult(Message.SuccessAdded);
        }

        public IResult DeleteById(int id)
        {
            var deletedEntity = _categoryDal.Get(category => category.Id == id);
            _categoryDal.Delete(deletedEntity);
            return new SuccessResult(Message.SuccessDeleted);
        }

        public IResult DeleteByName(string name)
        {
            var deletedEntity = _categoryDal.Get(c => c.Name.ToLower() == name.ToLower());
            _categoryDal.Delete(deletedEntity);
            return new SuccessResult(Message.SuccessDeleted);
        }

        public IDataResult<List<Category>> GetAll()
        {
            var result = _categoryDal.GetAll();
            return new SuccessDataResult<List<Category>>(result, Message.Completed);
        }

        public IDataResult<Category> GetById(int id)
        {
            var result =  _categoryDal.Get(c => c.Id == id);
            return new SuccessDataResult<Category>(result, Message.Completed);
        }
        public IDataResult<Category> GetByName(string name)
        {
            var result = _categoryDal.Get(c => c.Name.ToLower() == name.ToLower());
            return new SuccessDataResult<Category>(result, Message.Completed);
        }
        public IDataResult<Category> Update(Category category)
        {
            var result = _categoryDal.Update(category);
            return new SuccessDataResult<Category>(result, Message.SuccessUpdated);
        }
    }
}
