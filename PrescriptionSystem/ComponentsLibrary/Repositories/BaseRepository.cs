using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;

namespace ComponentsLibrary.Repositories
{
    public class BaseRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly PrescriptionSystemDbContext _context;
        private readonly DbSet<T> _dbSet;
        public BaseRepository(PrescriptionSystemDbContext context)
        {
            _context = context;
            _dbSet = context.Set<T>();
        }

        private void SaveChanges()
        {
            _context.SaveChanges();
        }

        public void Add(T entity)
        {
            _dbSet.Add(entity); 
            SaveChanges();
        }

        public void AddRange(IEnumerable<T> entities)
        {
            _dbSet.AddRange(entities);
            SaveChanges();
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
            SaveChanges();
        }

        public void RemoveRange(IEnumerable<T> entities)
        {
            _dbSet.RemoveRange(entities);
            SaveChanges();
        }
    }
}