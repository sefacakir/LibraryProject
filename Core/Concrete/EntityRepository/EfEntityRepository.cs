using Core.Abstract;
using Entities.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Core.Concrete.EntityRepository
{
    public class EfEntityRepository<TEntity, TContext>
        where TEntity:class,IEntity,new()
        where TContext:DbContext,new()
    {
        public void Add(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void DeleteById(int id)
        {
            throw new NotImplementedException();
        }

        public List<TEntity> GetAll(Expression<Func<TEntity,bool>> filter = null)
        {
            using(TContext context = new TContext())
            {
                if(filter == null)
                {
                    return context.Set<TEntity>().ToList();
                }
                else
                {
                    return context.Set<TEntity>().Where(filter).ToList();
                }
            }
            throw new NotImplementedException();
        }

        public TEntity Get(Expression<Func<TEntity,bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Update(TEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
