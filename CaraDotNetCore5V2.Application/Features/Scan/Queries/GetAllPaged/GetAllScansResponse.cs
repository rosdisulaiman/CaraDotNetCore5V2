using CaraDotNetCore5V2.Application.Features.Face.Commands.Create;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaraDotNetCore5V2.Application.Features.Scan.Queries.GetAllPaged
{
    public class GetAllScansResponse
    {
        public int LogId { get; set; }
        public DateTime LoggedTime { get; set; } = DateTime.Now;
        public string devid { get; set; }
        public string devname { get; set; }
        public int time { get; set; }
        public int timelocal { get; set; }
        public List<CreateFaceCommand> Faces { get; set; }
    }
}
