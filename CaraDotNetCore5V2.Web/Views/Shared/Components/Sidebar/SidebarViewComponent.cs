﻿using Microsoft.AspNetCore.Mvc;

namespace CaraDotNetCore5V2.Web.Views.Shared.Components.Sidebar
{
    public class SidebarViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}