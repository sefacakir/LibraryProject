using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
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


        public void Add(Category category)
        {
            _categoryDal.Add(category);
        }

        public void DeleteById(int id)
        {
            var deletedEntity = _categoryDal.Get(category => category.Id == id);
            _categoryDal.Delete(deletedEntity);
        }

        public void DeleteByName(string name)
        {
            var deletedEntity = _categoryDal.Get(c => c.Name.ToLower() == name.ToLower());
            _categoryDal.Delete(deletedEntity);
        }

        public List<Category> GetAll()
        {
            return _categoryDal.GetAll();
        }

        public Category GetById(int id)
        {
            return _categoryDal.Get(c => c.Id == id);
        }
        public Category GetByName(string name)
        {
            return _categoryDal.Get(c => c.Name.ToLower() == name.ToLower());
        }
        public void Update(Category category)
        {
            _categoryDal.Update(category);
        }
    }
}
