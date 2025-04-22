using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace Accounting.DataLayer.Services
{
    public class Repository<T> where T : class
    {
        private AccountingDbContext _context;
        private DbSet<T> _dbSet;

        public Repository(AccountingDbContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }

         public virtual IEnumerable<T> GetAll(Expression<Func<T,bool>> where=null)
       {
           IQueryable<T> query = _dbSet;

           if (where != null)
           {
               query = query.Where(where);
           }

           return query.ToList();
       }
        

        
        public virtual void Add(T entity)
        {
            _dbSet.Add(entity);
        }

        public virtual void Update(T entity)
        {
            _dbSet.Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;
        }

        public virtual T GetById(object id)
        {
           return  _dbSet.Find(id);
        }

        public virtual void Remove(T entity)
        {
            if (_context.Entry(entity).State == EntityState.Detached)
            {
                _dbSet.Attach(entity);
            }

            _dbSet.Remove(entity);
        }

        public virtual void Remove(object id)
        {
            var entity = GetById(id);
            Remove(entity);
        }
    }
}