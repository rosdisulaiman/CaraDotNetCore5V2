﻿using Microsoft.AspNetCore.Mvc;

namespace CaraDotNetCore5V2.Web.Views.Shared.Components.Footer
{
    public class FooterViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}