using Microsoft.AspNetCore.Mvc;

namespace CaraDotNetCore5V2.Web.Views.Shared.Components.Title
{
    public class TitleViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}