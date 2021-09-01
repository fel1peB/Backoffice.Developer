using Microsoft.AspNetCore.Mvc;
using Backoffice.Developer.Application.Interface;
using Backoffice.Developer.Domain.Entities;
using System.Threading.Tasks;
using Backoffice.Developer.Application.Models;

namespace Backoffice.Developer.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SkillController : ControllerBase
    {
        protected readonly IService<SkillModel> _service;

        public SkillController(IService<SkillModel> service)
        {
            _service = service;
        }

        [HttpPost]
        public async Task<ActionResult> InsertAsync([FromBody] SkillModel model)
        {
            await _service.AddAsync(model);
            return Ok();
        }
    }
}
