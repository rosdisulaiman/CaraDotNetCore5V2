using CaraDotNetCore5V2.API.Controllers;
using CaraDotNetCore5V2.Application.Features.Scan.Commands.Create;
using CaraDotNetCore5V2.Application.Features.Scan.Queries.GetAllPaged;
using CaraDotNetCore5V2.Application.Features.Scan.Queries.GetById;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CaraDotNetCore5V2.Api.Controllers.v1
{
    [Route("api/[controller]")]
    [ApiController]
    [AllowAnonymous]
    public class ScanController : BaseApiController<ScanController>
    {

        //[HttpGet]
        //public async Task<IActionResult> GetAll(int pageNumber, int pageSize)
        //{
        //    var scans = await _mediator.Send(new GetAllScansQuery(pageNumber, pageSize));

        //    return Ok(scans);
        //}

        //[HttpGet("{id}")]
        //public async Task<IActionResult> GetById(int id)
        //{
        //    var scan = await _mediator.Send(new GetScanByIdQuery() { LogId = id });
        //    return Ok(scan);
        //}

        // POST api/<controller>
        [HttpPost]
        public async Task<IActionResult> Post(CreateScanCommand command)
        {
            return Ok(await _mediator.Send(command));
        }

        // DELETE api/<controller>/5
        //[HttpDelete("{id}")]
        //public async Task<IActionResult> Delete(int id)
        //{
        //    return Ok(await _mediator.Send(new DeleteScanCommand { Id = id }));
        //}
    }
}
