using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using ComponentsLibrary.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ComponentsLibrary.Repositories.Implementations
{
    public class BaseRepository<T> : IGenericRepository<T> where T : class
    {
        protected readonly PrescriptionSystemDbContext _context;
        protected readonly DbSet<T> _dbSet;
        public BaseRepository(PrescriptionSystemDbContext context)
        {
            _context = context;
            _dbSet = context.Set<T>();
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        public void Add(T entity)
        {
            _dbSet.Add(entity); 
        }

        public void AddRange(IEnumerable<T> entities)
        {
            _dbSet.AddRange(entities);
        }

        public IEnumerable<T> Find(Expression<Func<T, bool>> expression)
        {
            return _dbSet.Where(expression);
        }

        public IEnumerable<T> GetAll()
        {
            return _dbSet.ToList();
        }

        public T GetById(int id)
        {
            return _dbSet.Find(id);
        }

        public void Remove(T entity)
        {
            _dbSet.Remove(entity);
        }

        public void RemoveRange(IEnumerable<T> entities)
        {
            _dbSet.RemoveRange(entities);
        }
    }
}