using DiziSinema.MVC.Areas.Admin.Models.Movie;
using DiziSinema.MVC.Areas.Admin.Models;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using DiziSinema.MVC.Models.MovieViewModels;
using DiziSinema.MVC.Models.GenreViewModels;
using DiziSinema.MVC.Areas.Admin.Models.Genre;
using System.Reflection;

namespace DiziSinema.MVC.Controllers
{
    public class MovieController : Controller
    {
        public async Task<IActionResult> Index()
        {
            Response<List<MovieMainViewModel>> response = new Response<List<MovieMainViewModel>>();
            using (HttpClient httpClient = new HttpClient())
            {
                HttpResponseMessage responseApi = await httpClient.GetAsync($"http://localhost:4100/Movies");
                string contentResponseApi = await responseApi.Content.ReadAsStringAsync();
                response = JsonSerializer.Deserialize<Response<List<MovieMainViewModel>>>(contentResponseApi);
            }
            return View(response.Data);
        }

        [NonAction]
        public async Task<GenreViewModel> GetGenresIdAsync(int id)
        {
            Response<GenreViewModel> response = new Response<GenreViewModel>();
            using (HttpClient httpClient = new HttpClient())
            {
                HttpResponseMessage responseApi = await httpClient.GetAsync($"http://localhost:4100/Genres/{id}");
                string contentResponseApi = await responseApi.Content.ReadAsStringAsync();
                response = JsonSerializer.Deserialize<Response<GenreViewModel>>(contentResponseApi);
                return response.Data;
            }
        }

        [NonAction]
        public async Task<MovieDetailViewModel> GetGenresAsync(int id)
        {
            Response<MovieDetailViewModel> response = new Response<MovieDetailViewModel>();
            using (HttpClient httpClient = new HttpClient())
            {
                HttpResponseMessage responseApi = await httpClient.GetAsync($"http://localhost:4100/Movies/GetWithGenres/{id}");
                string contentResponseApi = await responseApi.Content.ReadAsStringAsync();
                response = JsonSerializer.Deserialize<Response<MovieDetailViewModel>>(contentResponseApi);
                return response.Data;
            }
        }

        public async Task<IActionResult> Detail(int? id= null)
        {
            Response<MovieDetailViewModel> response = new Response<MovieDetailViewModel>();
            using (HttpClient httpClient = new HttpClient())
            {
                await GetGenresAsync(Convert.ToInt32(id));
                var genre = id != null ? await GetGenresIdAsync(Convert.ToInt32(id)): null;
                ViewBag.MovieList = genre. !=null ? response.Data. : null;
            }
            return View(response.Data);
        }







    }
}
