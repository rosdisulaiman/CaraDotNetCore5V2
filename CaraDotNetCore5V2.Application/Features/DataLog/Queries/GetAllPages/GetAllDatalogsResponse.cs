using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaraDotNetCore5V2.Application.Features.DataLog.Queries.GetAllPages
{
    public class GetAllDatalogsResponse
    {
        public int Id { get; set; }
        public string name { get; set; }
        public float? temperature { get; set; }
        public DateTimeOffset timelocal { get; set; }
        public string devname { get; set; }

    }
}
