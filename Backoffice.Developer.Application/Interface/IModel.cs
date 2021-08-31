using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backoffice.Developer.Application.Interface
{
    public interface IModel
    {
        public string Id { get; set; }
        public DateTime LastUpdate { get; set; }
    }
}
