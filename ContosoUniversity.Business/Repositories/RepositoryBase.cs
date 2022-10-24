using ContosoUniversity.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ContosoUniversity.Business.Repositories
{
    public abstract class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        protected ContosoUniversityContext _DbContext { get; set; }
        public RepositoryBase(ContosoUniversityContext DbContext)
        {
            _DbContext = DbContext;
        }
        public virtual IQueryable<T> Query(Expression<Func<T, bool>> expression)
        {
            return _DbContext.Set<T>().Where(expression).AsNoTracking();
        }
        public virtual async Task<bool> AddAsync(T entity)
        {
            await _DbContext.Set<T>().AddAsync(entity);
            return true;
        }
        public virtual async Task<T> FindAsync(Expression<Func<T, bool>> expression)
        {
            return await _DbContext.Set<T>().Where(expression).FirstOrDefaultAsync();
        }
        public virtual async Task<bool> RemoveAsyncWhere(Expression<Func<T, bool>> expression)
        {
            var entity = await FindAsync(expression);
            if (entity != null)
            {
                Remove(entity);
                return true;
            }
            return false;
        }
        public virtual async Task<bool> RemoveRangeAsyncWhere(Expression<Func<T, bool>> expression)
        {
            var entities = await ToListAsyncWhere(expression);
            if (entities != null && entities.Count() > 0)
            {
                RemoveRange(entities);
                return true;
            }
            return false;
        }
        public virtual bool Remove(T entity)
        {
            _DbContext.Set<T>().Remove(entity);
            return true;
        }
        public virtual bool RemoveRange(IEnumerable<T> entities)
        {
            _DbContext.Set<T>().RemoveRange(entities);
            return true;
        }
        public virtual async Task<IEnumerable<T>> ToListAsync()
        {
            return await _DbContext.Set<T>().ToListAsync();
        }
        public virtual async Task<IEnumerable<T>> ToListAsyncWhere(Expression<Func<T, bool>> expression)
        {
            return await _DbContext.Set<T>().Where(expression).ToListAsync();
        }
        public virtual bool Update(T entity)
        {
            return true;
        }
    }
}
