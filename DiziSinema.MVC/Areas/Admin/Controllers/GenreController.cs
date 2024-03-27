using DiziSinema.MVC.Areas.Admin.Models.Genre;
using DiziSinema.MVC.Areas.Admin.Models;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using System.Text;

namespace DiziSinema.MVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class GenreController : Controller
    {
        public async Task<IActionResult> Index()
        {
            Response<List<GenreViewModel>> response = new Response<List<GenreViewModel>>();
            using (HttpClient httpClient = new HttpClient())
            {
                HttpResponseMessage responseApı = await httpClient.GetAsync("http://localhost:4100/Genres");
                string contentResponseApi = await responseApı.Content.ReadAsStringAsync();
                response = JsonSerializer.Deserialize<Response<List<GenreViewModel>>>(contentResponseApi);
            }
            return View(response.Data);
        }
    }
}
