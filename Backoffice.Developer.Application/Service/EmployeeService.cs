using Mapster;
using System.Threading.Tasks;
using Backoffice.Developer.Application.Maps;

using Backoffice.Developer.Application.Interface;
using MongoDB.Bson;
using System.Collections.Generic;
using MongoDB.Driver;
using System.Linq;
using Backoffice.Developer.Infra.Data;
using Backoffice.Developer.Application.Models;
using Backoffice.Developer.Domain.Entities;

namespace Backoffice.Developer.Application.Service
{
    public class EmployeeService : IService<EmployeeModel>
    {
        private readonly Repository<Employee> _repo;
        public EmployeeService(Repository<Employee> repo) 
        {
            _repo = repo;
        }

        public async Task AddAsync(EmployeeModel entity)
        {
            var domainEntity = entity.Adapt<Employee>();

            var validationResult = domainEntity.Validate();
            if (validationResult.Any())
                throw new System.Exception(validationResult.ToJson());

            await _repo.CreateAsync(domainEntity);
        }

        public Task DeleteAsync(EmployeeModel entity)
        {
            throw new System.NotImplementedException();
        }

        public Task<EmployeeModel> FindAsync(ObjectId id)
        {
            throw new System.NotImplementedException();
        }

        public Task<List<EmployeeModel>> FindAsync(FilterDefinition<EmployeeModel> build)
        {
            throw new System.NotImplementedException();
        }

        public async Task<IEnumerable<EmployeeModel>> GetAllAsync()
        {
            var list = await _repo.GetAll();
            return list.Adapt<IEnumerable<EmployeeModel>>();
        }

        public Task UpdateAsync(EmployeeModel entity)
        {
            throw new System.NotImplementedException();
        }
    }
}
