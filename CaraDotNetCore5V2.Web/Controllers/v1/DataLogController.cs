using AutoMapper;
using CaraDotNetCore5V2.Application.Features.DataLog.Commands.Create;
using CaraDotNetCore5V2.Application.Features.DataLog.Queries.GetAllPages;
using CaraDotNetCore5V2.Application.Features.DataLog.Queries.GetById;
using CaraDotNetCore5V2.Domain.Entities.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace CaraDotNetCore5V2.Web.Controllers.v1
{
    [AllowAnonymous]
    public class DataLogController : BaseApiController<DataLogController>
    {

        private readonly IMapper _mapper;

        public DataLogController(IMapper mapper)
        {
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll(int pageNumber, int pageSize)
        {
            var datalogs = await _mediator.Send(new GetAllDatalogsQuery(pageNumber, pageSize));
            return Ok(datalogs);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var datalog = await _mediator.Send(new GetDatalogByIdQuery() { Id = id });
            return Ok(datalog);
        }

        // POST api/<controller>
        [HttpPost]
        public async Task<IActionResult> Post(Root command)
        {
            CreateDataLogCommand result = _mapper.Map<CreateDataLogCommand>(command);
            result = _mapper.Map<Face, CreateDataLogCommand>(command.faces.FirstOrDefault(), result);
            return Ok(await _mediator.Send(result));
        }

        //// DELETE api/<controller>/5
        //[HttpDelete("{id}")]
        //public async Task<IActionResult> Delete(int id)
        //{
        //    return Ok(await _mediator.Send(new DeleteProductCommand { Id = id }));
        //}
    }
}
