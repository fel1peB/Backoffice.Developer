using System;
using Mapster;
using MongoDB.Bson;
using System.Collections.Generic;
using Backoffice.Developer.Domain.Common;
using Backoffice.Developer.Domain.Interface;
using Backoffice.Developer.Domain.Validator;

namespace Backoffice.Developer.Domain.Entities
{
    public class Employee : IEntity
    {
        private readonly EmployeeValidator _validations = new();

        public ObjectId Id { get; set; }
        public DateTime LastUpdate { get; set; }
        public string Name { get; set; }

        public IEnumerable<ValidationResult> Validate()
        {
            return _validations.Validate(this).Errors.Adapt<IEnumerable<ValidationResult>>();
        }
    }
}
