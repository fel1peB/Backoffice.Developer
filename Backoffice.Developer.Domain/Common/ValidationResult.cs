using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backoffice.Developer.Domain.Common
{
    public class ValidationResult
    {
        public string PropertyName { get; set; }
        public string ErrorMessage { get; set; }
    }
}
