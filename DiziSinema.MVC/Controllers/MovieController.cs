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



        [NonAction]
        public async Task<GenreViewModel> GetMovie(int id)
        {
            Response<List<MovieViewModel>> Genre = new Response<List<MovieViewModel>>();
            using (HttpClient httpClient = new HttpClient())
            {
                HttpResponseMessage responseApi = await httpClient.GetAsync($"http://localhost:4100/Movie/GetAllWithGenres");
                string contentResponseApi = await responseApi.Content.ReadAsStringAsync();
                Genre = JsonSerializer.Deserialize<Response<List<MovieViewModel>>>(contentResponseApi);
            }
            return (Genre.Data);
        }

        [NonAction]
        public async Task<GenreViewModel> GetSerial(int id)
        {
            Response<GenreViewModel> Genre = new Response<GenreViewModel>();
            using (HttpClient httpClient = new HttpClient())
            {
                HttpResponseMessage responseApi = await httpClient.GetAsync($"http://localhost:4100/Movie/GetAllWithGenres");
                string contentResponseApi = await responseApi.Content.ReadAsStringAsync();
                Genre = JsonSerializer.Deserialize<Response<GenreViewModel>>(contentResponseApi);
            }
            return Genre.Data;
        }



        [HttpGet]
        public async Task<IActionResult> Genre(int id)
        {
                GenreViewModel movieViewModel = await GetGenre(id);
                MovieMainViewModel model = new MovieMainViewModel
                {
                    
                };
            return View(model);
        }



    }
}
