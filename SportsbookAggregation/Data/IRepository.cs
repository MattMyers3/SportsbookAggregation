using System.Linq;

namespace SportsbookAggregation.Data
{
    public interface IRepository<T>
    {
        IQueryable<T> Read();
        void Create(T entity);
        void Delete(T entity);
        void Update(T entity);
    }
}