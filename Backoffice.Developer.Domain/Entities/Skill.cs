using Backoffice.Developer.Domain.Common;
using Backoffice.Developer.Domain.Interface;
using Backoffice.Developer.Domain.Validator;
using Mapster;
using MongoDB.Bson;
using System;
using System.Collections.Generic;

namespace Backoffice.Developer.Domain.Entities
{
    public class Skill : IEntity
    {
        private readonly SkillValidator _validations = new();

        public ObjectId Id { get; set; }
        public DateTime LastUpdate { get; set; }
        public string Description { get; set; }

        public IEnumerable<ValidationResult> Validate()
        {
            return _validations.Validate(this).Errors.Adapt<IEnumerable<ValidationResult>>();
        }
    }
}
