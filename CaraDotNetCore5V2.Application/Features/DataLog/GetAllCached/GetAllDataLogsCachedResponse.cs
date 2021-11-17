using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaraDotNetCore5V2.Application.Features.DataLog.GetAllCached
{
    public class GetAllDataLogsCachedResponse
    {
        public int Id { get; set; }
        public string QRcode { get; set; }
        public string name { get; set; }
        public float? temperature { get; set; }
        public DateTimeOffset timelocal { get; set; }
        public DateTime LoggedTime { get; set; }
        public string devname { get; set; }
        public string image { get; set; }
    }
}
