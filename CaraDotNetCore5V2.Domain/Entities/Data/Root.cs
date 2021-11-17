using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaraDotNetCore5V2.Domain.Entities.Data
{
    public class Root
    {
        public string camid { get; set; }
        public string devid { get; set; }
        public string devmac { get; set; }
        public string devname { get; set; }
        public string devno { get; set; }
        public List<Face> faces { get; set; }
        public int time { get; set; }
        public int timelocal { get; set; }
        public string type { get; set; }
    }
}
