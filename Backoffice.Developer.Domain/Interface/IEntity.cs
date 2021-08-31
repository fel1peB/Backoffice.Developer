using System;
using MongoDB.Bson;
using System.Collections.Generic;
using Backoffice.Developer.Domain.Common;

namespace Backoffice.Developer.Domain.Interface
{
    public interface IEntity
    {
        public ObjectId Id { get; set; }
        public DateTime LastUpdate { get; set; }
        IEnumerable<ValidationResult> Validate();
    }
}
