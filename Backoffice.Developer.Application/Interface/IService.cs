using Backoffice.Developer.Domain.Interface;
using MongoDB.Bson;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Backoffice.Developer.Application.Interface
{
    public interface IService<T> where T : IModel
    {
        public Task AddAsync(T model);
        public Task UpdateAsync(T model);
        public Task<IEnumerable<T>> GetAllAsync();
        public Task DeleteAsync(T model);
        public Task<T> FindAsync(ObjectId id);
        public Task<List<T>> FindAsync(FilterDefinition<T> build);
    }
}
