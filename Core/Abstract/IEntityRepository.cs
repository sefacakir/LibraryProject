﻿using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.Abstract
{
    public interface IEntityRepository<T>
    {
        public void Add(T entity);
        public void DeleteById(int id);
        public void Update(T entity);
        public T Get(Expression<Func<T, bool>> filter);
        public List<T> GetAll(Expression<Func<T, bool>> filter = null);
    }
}
