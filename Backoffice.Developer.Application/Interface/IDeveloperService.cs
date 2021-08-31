using MongoDB.Bson;
using MongoDB.Driver;
using System.Threading.Tasks;
using System.Collections.Generic;
using DeveloperModel =  Backoffice.Developer.Application.Models.Developer;

namespace Backoffice.Developer.Application.Interface
{
    public interface IDeveloperService
    {
        public Task AddAsync(DeveloperModel entity);
        public Task UpdateAsync(DeveloperModel entity);
        public Task<IEnumerable<DeveloperModel>> GetAllAsync();
        public Task DeleteAsync(DeveloperModel entity);
        public Task<DeveloperModel> FindAsync(ObjectId id);
        public Task<List<DeveloperModel>> FindAsync(FilterDefinition<DeveloperModel> build);
    }
}
