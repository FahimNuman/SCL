using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;


namespace SCL.Data
{
    public interface IRepository<T> where T : class
    {
        void Add(T entity);
        void Edit(T entityToUpdate);

        IEnumerable<T> Get(
            out int total, out int totalDisplay,
            Expression<Func<T, bool>> filter = null,
            Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
            string includeProperties = "", int pageIndex = 1, int pageSize = 10, bool isTrackingOff = false);

        IEnumerable<T> Get(Expression<Func<T, bool>> filter = null,
            Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
            string includeProperties = "", bool isTrackingOff = false);

        T GetById(int id);
        int GetCount(Expression<Func<T, bool>> filter = null);
        void Remove(int id);
        void Remove(T entityToDelete);
        void Remove(Expression<Func<T, bool>> filter);
    }
}
