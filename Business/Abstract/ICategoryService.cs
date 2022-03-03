using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Business.Abstract
{
    public interface ICategoryService
    {
        public void Add(Category category);
        public void DeleteById(int id);
        public void DeleteByName(string name);
        public Category GetById(int id);
        public Category GetByName(string name);
        public void Update(Category category);
        public List<Category> GetAll();
    }
}
