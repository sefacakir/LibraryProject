﻿using Core.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IBookDal : IEntityRepository<Book>
    {
        public List<BookDetailDto> GetBookDetail(Expression<Func<BookDetailDto, bool>> filter = null);
    }
}
