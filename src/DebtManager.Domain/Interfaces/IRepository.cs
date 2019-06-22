using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace DebtManager.Domain.Interfaces
{
    public interface IRepository<TEntity> : IDisposable where TEntity : new()
    {
        void Insert(TEntity obj);
        TEntity GetById(Guid id);
        IEnumerable<TEntity> GetAll();
        void Update(TEntity obj);
        void Delete(Guid id);
        IEnumerable<TEntity> Where(Expression<Func<TEntity, bool>> predicate);
        
    }
}
