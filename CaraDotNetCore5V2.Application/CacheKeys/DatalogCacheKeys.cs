using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaraDotNetCore5V2.Application.CacheKeys
{
    public class DatalogCacheKeys
    {
        public static string ListKey => "DataLogList";

        public static string SelectListKey => "DataLogSelectList";

        public static string GetKey(int Id) => $"Datalog-{Id}";

        public static string GetDetailsKey(int Id) => $"DatalogDetails-{Id}";
    }
}
