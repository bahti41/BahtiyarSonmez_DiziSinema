﻿using Microsoft.AspNetCore.Mvc;

namespace DiziSinema.MVC.Areas.Admin.ViewComponents
{
    public class MainSidebarViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }
    }
}
