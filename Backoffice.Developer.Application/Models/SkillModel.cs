using Backoffice.Developer.Application.Interface;
using System;
using System.Collections.Generic;

namespace Backoffice.Developer.Application.Models
{
    public class SkillModel : IModel
    {
        public string Id { get; set; }
        public DateTime LastUpdate { get; set; }
        public string Description { get; set; }

    }
}
