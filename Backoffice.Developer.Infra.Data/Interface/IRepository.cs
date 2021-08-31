using System;
using MongoDB.Bson;
using MongoDB.Driver;
using System.Threading.Tasks;
using System.Linq.Expressions;
using System.Collections.Generic;

namespace Backoffice.Developer.Infra.Data.Interface
{
    public interface IRepository<T>
    {
        Task<T> FindAsync(ObjectId id);
        Task CreateAsync(T entity);
        Task UpdateAsync(T entity);
        Task<List<T>> GetAll();
        Task<List<T>> FindAsync(Expression<Func<T, bool>> filter);
        Task<List<T>> FindAsync(FilterDefinition<T> build);
        Task DeleteAsync(Expression<Func<T, bool>> filterExpression);
        Task DeleteAsync(T entity);
    }
}
