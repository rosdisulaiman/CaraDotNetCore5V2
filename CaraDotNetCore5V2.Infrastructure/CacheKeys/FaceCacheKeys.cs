using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaraDotNetCore5V2.Infrastructure.CacheKeys
{
    public static class FaceCacheKeys
    {
        public static string ListKey => "FaceList";

        public static string SelectListKey => "FaceSelectList";

        public static string GetKey(int faceId) => $"Face-{faceId}";

        public static string GetDetailsKey(int faceId) => $"FaceDetails-{faceId}";
    }
}
