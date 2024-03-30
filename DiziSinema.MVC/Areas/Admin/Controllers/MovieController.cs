﻿using DiziSinema.MVC.Areas.Admin.Models.Movie;
using DiziSinema.MVC.Areas.Admin.Models;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using System.Text;
using DiziSinema.MVC.Areas.Admin.Models.Genre;
using MiniShop.MVC.Helpers;
using MiniShop.MVC.Extensions;


namespace DiziSinema.MVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class MovieController : Controller
    {



        #region Action
        public async Task<IActionResult> Index(bool id = false)
        {
            Response<List<MovieViewModel>> response = new Response<List<MovieViewModel>>();
            using (HttpClient httpClient = new HttpClient())
            {
                HttpResponseMessage responseApi = await httpClient.GetAsync($"http://localhost:4100/Movies/GetAllNonDeleted/{id}");
                string contentResponseApi = await responseApi.Content.ReadAsStringAsync();
                response = JsonSerializer.Deserialize<Response<List<MovieViewModel>>>(contentResponseApi);
            }
            ViewBag.ShowDeleted = id;
            return View(response.Data);
        }

        public async Task<IActionResult> UpdateIsActive(int id)
        {
            HttpClient httpClient = new HttpClient();

            HttpRequestMessage request = new HttpRequestMessage()
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri($"http://localhost:4100/Movies/UpdateIsActive/{id}"),
                Content = new StringContent("", Encoding.UTF8, "application/json")
            };
            HttpResponseMessage response = await httpClient.SendAsync(request);

            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> Create()
        {
            AddMovieViewModel model = new AddMovieViewModel
            {
                GenreList = await GetGenresAsync()
            };
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Create(AddMovieViewModel model, IFormFile image)
        {
            model.Url = Jobs.GetUrl(model.MovName);

            if (ModelState.IsValid && model.GenreIds.Count > 0 && image != null)
            {
                using (var httpClient = new HttpClient())
                {
                    //Resim Yükleme İşlemi
                    using (var stream = image.OpenReadStream())
                    {
                        var imageContent = new MultipartFormDataContent();
                        byte[] bytes = stream.ToByteArray();
                        imageContent.Add(new ByteArrayContent(bytes), "image", image.FileName);
                        HttpResponseMessage httpResponseMessage = await httpClient.PostAsync("http://localhost:4100/Movie/ImageUpload", imageContent);
                        string httpResponseMessageImageUrl = await httpResponseMessage.Content.ReadAsStringAsync();
                        if (httpResponseMessageImageUrl != null && httpResponseMessageImageUrl != "")
                        {
                            model.ImageUrl = httpResponseMessageImageUrl;
                            //Product Kayıt İşlemi
                            var serializeModel = JsonSerializer.Serialize(model);
                            StringContent stringContent = new StringContent(serializeModel, Encoding.UTF8, "application/json");
                            var result = await httpClient.PostAsync("http://localhost:4100/Movie/Create", stringContent);
                            if (result.IsSuccessStatusCode)
                            {
                                return RedirectToAction("Index");
                            }
                        }
                    }
                }
            }
            ViewBag.CategoryErrorMessage = model.GenreIds.Count == 0 ? "Herhangi bir kategori seçmeden, ürün kaydı yapılamaz" : null;
            ViewBag.ImageErrorMessage = model.ImageUrl == null || model.ImageUrl == "" ? "Resim hatalı!" : null;
            model.GenreList = await GetGenresAsync();

            return View(model);
        }

        //AutoMappper İle Yapılacak
        public async Task<IActionResult> Edit(int id)
        {
            

            MovieViewModel movieViewModel = await GetMovieAsync(id);
            EditMovieViewModel model = new EditMovieViewModel
            {
                Id = movieViewModel.Id,
                MovName = movieViewModel.MovName,
                Movlanguage = movieViewModel.Movlanguage,
                ImageUrl = movieViewModel.ImageUrl,
                IsActive = movieViewModel.IsActive,
                MovIntro = movieViewModel.MovIntro,
                Url = movieViewModel.Url,
                GenreIds = movieViewModel.Genres.Select(c => c.Id).ToList(),
                GenreList = await GetGenresAsync()
            };
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(EditMovieViewModel model, IFormFile image, string oldImageUrl)
        {

            model.Url = Jobs.GetUrl(model.MovName);

            if (ModelState.IsValid && model.GenreIds.Count > 0)
            {
                using (var httpClient = new HttpClient())
                {



                    //Resim Yükleme İşlemi
                    using (var stream = image != null ? image.OpenReadStream() : null)
                    {
                        if (image != null)
                        {
                            var imageContent = new MultipartFormDataContent();
                            byte[] bytes = stream.ToByteArray();
                            imageContent.Add(new ByteArrayContent(bytes), "image", image.FileName);
                            HttpResponseMessage httpResponseMessage = await httpClient.PostAsync("http://localhost:4100/Movie/ImageUpload", imageContent);
                            string httpResponseMessageImageUrl = await httpResponseMessage.Content.ReadAsStringAsync();
                            if (httpResponseMessageImageUrl != null && httpResponseMessageImageUrl != "")
                            {
                                model.ImageUrl = httpResponseMessageImageUrl;

                            }
                        }




                        var serializeModel = JsonSerializer.Serialize(model);
                        StringContent stringContent = new StringContent(serializeModel, Encoding.UTF8, "application/json");
                        var result = await httpClient.PutAsync("http://localhost:7700/Products/Update", stringContent);
                        if (result.IsSuccessStatusCode)
                        {
                            return RedirectToAction("Index");
                        }


                    }
                }
            }
            ViewBag.CategoryErrorMessage = model.GenreIds.Count == 0 ? "Herhangi bir kategori seçmeden, ürün kaydı yapılamaz" : null;
            model.GenreList = await GetGenresAsync();
            return View(model);
        }

        //AutoMapper İle Yapılacak
        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            MovieViewModel movieViewModel = await GetMovieAsync(id);
            DeletedMovieViewModel model = new DeletedMovieViewModel
            {
                Id = movieViewModel.Id,
                MovName = movieViewModel.MovName,
                Movlanguage = movieViewModel.Movlanguage,
                CreatedDate = movieViewModel.CreatedDate,
                ModifiedDate = movieViewModel.ModifiedDate,
                IsDeleted = movieViewModel.IsDeleted,
            };
            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> HardDelete(int id)
        {
            using (var httpClient = new HttpClient())
            {
                HttpResponseMessage responseApi = await httpClient.DeleteAsync($"http://localhost:4100/Movie/HardDelete/{id}");
            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> SoftDelete(int id)
        {
            using (var httpClient = new HttpClient())
            {
                HttpResponseMessage responseApi = await httpClient.DeleteAsync($"http://localhost:4100/Movie/SoftDelete/{id}");
            }
            var movieViewModel = await GetByIdAsync(id);
            return Redirect($"/Admin/Movie/Index/{!movieViewModel.IsDeleted}");
        }


        #endregion

        #region NonActions
        [NonAction]
        public async Task<List<GenreViewModel>> GetGenresAsync()
        {
            Response<List<GenreViewModel>> response = new Response<List<GenreViewModel>>();
            using (HttpClient httpClient = new HttpClient())
            {
                HttpResponseMessage responseApi = await httpClient.GetAsync("http://localhost:4100/Genres");
                string contentResponseApi = await responseApi.Content.ReadAsStringAsync();
                response = JsonSerializer.Deserialize<Response<List<GenreViewModel>>>(contentResponseApi);
            }
            return response.Data;
        }

        [NonAction]
        public async Task<MovieViewModel> GetMovieAsync(int id)
        {
            Response<MovieViewModel> response = new Response<MovieViewModel>();
            using (HttpClient httpClient = new HttpClient())
            {
                HttpResponseMessage responseApi = await httpClient.GetAsync($"http://localhost:4100/Movies/GetWithCategories/{id}");
                string contentResponseApi = await responseApi.Content.ReadAsStringAsync();
                response = JsonSerializer.Deserialize<Response<MovieViewModel>>(contentResponseApi);
            }
            return response.Data;
        }

        [NonAction]
        public async Task<MovieViewModel> GetByIdAsync(int id)
        {
            Response<MovieViewModel> response = new Response<MovieViewModel>();
            using (HttpClient httpClient = new HttpClient())
            {
                HttpResponseMessage responseApi = await httpClient.GetAsync($"http://localhost:4100/Movies/{id}");
                string contentResponseApi = await responseApi.Content.ReadAsStringAsync();
                response = JsonSerializer.Deserialize<Response<MovieViewModel>>(contentResponseApi);
            }
            return response.Data;
        }
        #endregion


    }
}
