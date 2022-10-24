using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ContosoUniversity.Business.Repositories
{
    public interface IRepositoryBase<T> where T : class
    {
        IQueryable<T> Query(Expression<Func<T, bool>> expression);

        // Single entity
        Task<T> FindAsync(Expression<Func<T, bool>> expression);

        // List
        Task<IEnumerable<T>> ToListAsync();
        Task<IEnumerable<T>> ToListAsyncWhere(Expression<Func<T, bool>> expression);
        
        // Add
        Task<bool> AddAsync(T entity);

        // Update
        bool Update(T entity);

        // Remove
        Task<bool> RemoveAsyncWhere(Expression<Func<T, bool>> expression);
        Task<bool> RemoveRangeAsyncWhere(Expression<Func<T, bool>> expression);
        bool Remove(T entity);
        bool RemoveRange(IEnumerable<T> entities);
    }
}
