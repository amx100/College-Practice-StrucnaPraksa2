using System;
using System.Linq;
using System.Linq.Expressions;

namespace Application.Contracts
{
    public interface IBaseRepository<T>
    {
        IQueryable<T> SelectAll();
        IQueryable<T> SelectByCondition(Expression<Func<T, bool>> expression);
        void Create(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
