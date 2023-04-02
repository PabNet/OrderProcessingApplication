using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using OrderProcessingApplication.Domain.Repositories.Abstractions;
using OrderProcessingApplication.Domain.Services;

namespace OrderProcessingApplication.Domain.Repositories.Implementations
{
    public class OrderRepository<TEntity, TContext> : IGenericRepository<TEntity> where TEntity : class
                                                                                        where TContext : DbContext
    {
        private readonly TContext _context;
        private readonly DbSet<TEntity> _dbSet;

        public OrderRepository(TContext context)
        {
            _context = context;
            _dbSet = context.Set<TEntity>();
        }
 
        public void Create(TEntity item)
        {
            if (item == null)
            {
                throw new ArgumentException(nameof(item));
            }
            _context.Add(item);
            
            _context.SaveChanges();
        }

        public void CreateOrUpdate(TEntity item, Func<TEntity, bool> predicate)
        {
            if (item == null)
            {
                throw new ArgumentNullException(nameof(item));    
            }

            var dbEntity = Get(predicate).FirstOrDefault();
            if (dbEntity != null)
            {
                Update(item);
            }
            else
            {
                Create(item);
            }
        }

        public IEnumerable<TEntity> Get()
        {
            return _dbSet.ToList();
        }

        public IEnumerable<TEntity> Get(Func<TEntity, bool> predicate)
        {
            if (predicate == default)
            {
                throw new ArgumentException(nameof(predicate));
            }
            
            return _dbSet.ToList().Where(e => predicate(e));
        }

        public void Remove(TEntity? item)
        {
            if (item == default)
            {
                throw new ArgumentException(nameof(item));
            }

            _context.Remove(item);
            
            _context.SaveChanges();
        }

        public void Update(TEntity item)
        {
            if (item == default)
            {
                throw new ArgumentException(nameof(item));
            }
            
            _context.Update(item);
            
            _context.SaveChanges();
        }
    }
}