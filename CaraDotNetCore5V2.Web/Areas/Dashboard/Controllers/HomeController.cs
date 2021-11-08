using CaraDotNetCore5V2.Web.Abstractions;
using Microsoft.AspNetCore.Mvc;

namespace CaraDotNetCore5V2.Web.Areas.Dashboard.Controllers
{
    [Area("Dashboard")]
    public class HomeController : BaseController<HomeController>
    {
        public IActionResult Index()
        {
            _notify.Information("Hi There!");
            return View();
        }
    }
}