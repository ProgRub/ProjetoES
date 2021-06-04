using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace ComponentsLibrary.Repositories.Interfaces
{
    public interface IGenericRepository<T> where T : class
    {
        void SaveChanges();
        T GetById(int id);
        IEnumerable<T> GetAll();
        IEnumerable<T> Find(Expression<Func<T, bool>> expression);
        void Add(T entity);
        void AddRange(IEnumerable<T> entities);
        void Remove(T entity);
        void RemoveRange(IEnumerable<T> entities);
    }
}