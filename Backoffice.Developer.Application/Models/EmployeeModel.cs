
using Backoffice.Developer.Application.Interface;
using System;

namespace Backoffice.Developer.Application.Models
{
    public class EmployeeModel : IModel
    {
        public string Id { get; set; }
        public DateTime LastUpdate { get; set; }
        public string Name { get; set; }
    }
}
