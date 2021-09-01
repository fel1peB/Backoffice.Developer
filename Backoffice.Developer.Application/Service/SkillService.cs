using Backoffice.Developer.Application.Interface;
using Backoffice.Developer.Application.Models;
using Backoffice.Developer.Domain.Entities;
using Backoffice.Developer.Infra.Data;
using Mapster;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backoffice.Developer.Application.Service
{
    public class SkillService : IService<SkillModel>
    {
        private readonly Repository<Skill> _repo;

        public SkillService(Repository<Skill> repo)
        {
            _repo = repo;
        }

        public async Task AddAsync(SkillModel entity)
        {
            var skillEntity = entity.Adapt<Skill>();

            var validationResult = skillEntity.Validate();
            if (validationResult.Any())
                throw new Exception(validationResult.ToJson());

            await _repo.CreateAsync(skillEntity);
        }

        public Task DeleteAsync(SkillModel entity)
        {
            throw new NotImplementedException();
        }

        public Task<SkillModel> FindAsync(ObjectId id)
        {
            throw new NotImplementedException();
        }

        public Task<List<SkillModel>> FindAsync(FilterDefinition<SkillModel> build)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<SkillModel>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(SkillModel entity)
        {
            throw new NotImplementedException();
        }
    }
}
