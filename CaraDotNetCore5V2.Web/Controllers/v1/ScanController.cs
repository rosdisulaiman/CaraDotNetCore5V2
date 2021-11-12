using CaraDotNetCore5V2.Application.Features.Scan.Commands.Create;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CaraDotNetCore5V2.Web.Controllers.v1
{
    [Route("api/[controller]")]
    [ApiController]
    [AllowAnonymous]
    public class ScanController : BaseApiController<ScanController>
    {

        // POST api/<controller>
        [HttpPost]
        public async Task<IActionResult> Post(CreateScanCommand command)
        {
            return Ok(await _mediator.Send(command));
        }
    }
}
