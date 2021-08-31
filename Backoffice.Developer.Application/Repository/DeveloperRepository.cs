
using Backoffice.Developer.Infra.Data;
using DeveloperDomain = Backoffice.Developer.Domain.Entities.Developer;

namespace Backoffice.Developer.Application.Repository
{
    public class DeveloperRepository : Repository<DeveloperDomain>
    {
        public DeveloperRepository(Settings settings) : base(settings)
        {

        }
    }
}
