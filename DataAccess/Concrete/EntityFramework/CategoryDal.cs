using Core.Concrete.EntityRepository;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class CategoryDal : EfEntityRepository<Category,DatabaseContext> ,ICategoryDal
    {
    }
}
