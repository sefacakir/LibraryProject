using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IAuthorService
    {
        public void Add(Author author);
        public void DeleteById(int id);
        public void Update(Author author);
        public Author GetById(int id);
        public Author GetByName(string name);
        public List<Author> GetAll();
    }
}
