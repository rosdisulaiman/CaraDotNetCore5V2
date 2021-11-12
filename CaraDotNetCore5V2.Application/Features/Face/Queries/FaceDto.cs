using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaraDotNetCore5V2.Application.Features.Face.Queries
{
    public class FaceDto
    {
        public string name { get; set; }
        public float temperature { get; set; }
        public int timestamp { get; set; }
        public string image { get; set; }
    }
}
