
using Backoffice.Developer.Application.Interface;
using System;
using System.Collections.Generic;

namespace Backoffice.Developer.Application.Models
{
    public class EmployeeModel : IModel
    {
        public string Id { get; set; }
        public DateTime LastUpdate { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public List<TechnologyModel> Technologies { get; set; }

    }
}
