using DiziSinema.MVC.Areas.Admin.Models.Movie;
using DiziSinema.MVC.Areas.Admin.Models;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using DiziSinema.MVC.Models.MovieViewModels;

namespace DiziSinema.MVC.Controllers
{
    public class MovieController : Controller
    {
        public async Task<IActionResult> Index(int id)
        {
            Response<MovieDetailViewModel> response = new Response<MovieDetailViewModel>();
            using (HttpClient httpClient = new HttpClient())
            {
                HttpResponseMessage responseApi = await httpClient.GetAsync($"http://localhost:4100/Movies/GetWithGenres/{id}");
                string contentResponseApi = await responseApi.Content.ReadAsStringAsync();
                response = JsonSerializer.Deserialize<Response<MovieDetailViewModel>>(contentResponseApi);
            }
            return View(response.Data);
        }
    }
}
