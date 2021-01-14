using System;
using System.Collections.Generic;
using System.Linq;

namespace SportsbookAggregation.Data
{
    public interface IRepository<T>
    {
        IQueryable<T> Read();
        void CreateWithoutSaving(T entity);
        void Delete(T entity);
        void Update(T entity);
        void UpdateRange(IEnumerable<Object> entities);
    }
}