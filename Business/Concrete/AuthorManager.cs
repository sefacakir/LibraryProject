﻿using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
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
        public void Add(Author author)
        {
            _authorDal.Add(author);
        }

        public void DeleteById(int id)
        {
            _authorDal.DeleteById(id);
        }

        public List<Author> GetAll()
        {
            return _authorDal.GetAll();
        }

        public Author GetById(int id)
        {
            return _authorDal.Get(c => c.Id == id);
        }

        public Author GetByName(string name)
        {
            return _authorDal.Get(c => c.Name.ToLower() == name.ToLower());
        }

        public void Update(Author author)
        {
            _authorDal.Update(author);
        }
    }
}
