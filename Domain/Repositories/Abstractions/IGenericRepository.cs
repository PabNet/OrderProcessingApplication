using System;
using System.Collections.Generic;

namespace OrderProcessingApplication.Domain.Repositories.Abstractions
{
    public interface IGenericRepository<TEntity> where TEntity : class
    {
        void Create(TEntity item);
        public void CreateOrUpdate(TEntity item, Func<TEntity, bool> predicate);
        IEnumerable<TEntity> Get();
        IEnumerable<TEntity> Get(Func<TEntity, bool> predicate);
        void Remove(TEntity? item);
        void Update(TEntity item);
    }
}