using Mapster;
using System.Threading.Tasks;
using Backoffice.Developer.Application.Repository;
using DeveloperDomain = Backoffice.Developer.Domain.Entities.Developer;
using DeveloperModel = Backoffice.Developer.Application.Models.Developer;
using Backoffice.Developer.Application.Interface;
using MongoDB.Bson;
using System.Collections.Generic;
using MongoDB.Driver;
using System.Linq;
using Backoffice.Developer.Infra.Data;

namespace Backoffice.Developer.Application.Service
{
    public class DeveloperService : IDeveloperService
    {
        private readonly Repository<DeveloperDomain> _repo;
        public DeveloperService(Repository<DeveloperDomain> repo) 
        {
            _repo = repo;
        }

        public async Task AddAsync(DeveloperModel entity)
        {
            var domainEntity = entity.Adapt<DeveloperDomain>();
            var validationResult = domainEntity.Validate();
            if (validationResult.Count() > 0)
                throw new System.Exception(validationResult.ToJson());
            await _repo.CreateAsync(domainEntity);
        }

        public Task DeleteAsync(DeveloperModel entity)
        {
            throw new System.NotImplementedException();
        }

        public Task<DeveloperModel> FindAsync(ObjectId id)
        {
            throw new System.NotImplementedException();
        }

        public Task<List<DeveloperModel>> FindAsync(FilterDefinition<DeveloperModel> build)
        {
            throw new System.NotImplementedException();
        }

        public Task<IEnumerable<DeveloperModel>> GetAllAsync()
        {
            throw new System.NotImplementedException();
        }

        public Task UpdateAsync(DeveloperModel entity)
        {
            throw new System.NotImplementedException();
        }
    }
}
