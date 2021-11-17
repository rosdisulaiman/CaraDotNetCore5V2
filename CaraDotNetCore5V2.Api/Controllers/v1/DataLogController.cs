using AutoMapper;
using CaraDotNetCore5V2.API.Controllers;
using CaraDotNetCore5V2.Application.Features.DataLog.Commands.Create;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CaraDotNetCore5V2.Api.Controllers.v1
{
    [AllowAnonymous]
    public class DataLogController : BaseApiController<DataLogController>
    {

        private readonly IMapper _mapper;

        public DataLogController(IMapper mapper)
        {
            _mapper = mapper;
        }
        // POST api/<controller>
        [HttpPost]
        public async Task<IActionResult> Post(Root command)
        {
            CreateDataLogCommand result = _mapper.Map<CreateDataLogCommand>(command);
            result = _mapper.Map<Face, CreateDataLogCommand>(command.faces.FirstOrDefault(),result);
            return Ok(await _mediator.Send(result));
        }
    }
}
