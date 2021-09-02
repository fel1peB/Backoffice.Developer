using Backoffice.Developer.Application.Interface;
using System;
using System.Collections.Generic;

namespace Backoffice.Developer.Application.Models
{
    public class TechnologyModel : IModel
    {
        public string Id { get; set; }
        public DateTime LastUpdate { get; set; }
        public string Name { get; set; }
        public int TimeWorked { get; set; }
        public List<SkillModel> Skills { get; set; }
    }
}
