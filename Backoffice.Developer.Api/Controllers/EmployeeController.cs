using Backoffice.Developer.Application.Interface;
using Backoffice.Developer.Application.Service;
using Mapster;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Backoffice.Developer.Application.Models;

namespace Backoffice.Developer.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        protected readonly IService<EmployeeModel> _service;

        public EmployeeController(IService<EmployeeModel> Service)
        {
            _service = Service;
        }

        [HttpPost]
        public async Task<ActionResult> InsertAsync([FromBody] EmployeeModel model)
        {
            await _service.AddAsync(model);
            return Ok();
        }
    }
}
