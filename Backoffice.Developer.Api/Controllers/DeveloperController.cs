using Backoffice.Developer.Application.Interface;
using Backoffice.Developer.Application.Service;
using Mapster;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using DeveloperModel = Backoffice.Developer.Application.Models.Developer;

namespace Backoffice.Developer.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DeveloperController : ControllerBase
    {
        protected readonly IDeveloperService _service;

        public DeveloperController(IDeveloperService Service)
        {
            _service = Service;
        }

        [HttpPost]
        public async Task<ActionResult> InsertAsync([FromBody] DeveloperModel model)
        {
            await _service.AddAsync(model);
            return Ok();
        }
    }
}
