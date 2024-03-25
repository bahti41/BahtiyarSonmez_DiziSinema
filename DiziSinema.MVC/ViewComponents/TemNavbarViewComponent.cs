using Microsoft.AspNetCore.Mvc;

namespace DiziSinema.MVC.Areas.ViewComponents
{
    public class TemNavbarViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }
    }
}
