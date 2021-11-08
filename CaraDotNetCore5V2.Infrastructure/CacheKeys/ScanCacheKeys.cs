using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaraDotNetCore5V2.Infrastructure.CacheKeys
{
    public static class ScanCacheKeys
    {
        public static string ListKey => "ScanList";

        public static string SelectListKey => "ScanSelectList";

        public static string GetKey(int logId) => $"Scan-{logId}";

        public static string GetDetailsKey(int logId) => $"ScanDetails-{logId}";
    }
}
