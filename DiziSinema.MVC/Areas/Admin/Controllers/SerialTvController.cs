using DiziSinema.MVC.Areas.Admin.Models.SerialTv;
using DiziSinema.MVC.Areas.Admin.Models;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using System.Text;

namespace DiziSinema.MVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SerialTvController : Controller
    {
        public async Task<IActionResult> Index()
        {
            Response<List<SerialTvViewModel>> response = new Response<List<SerialTvViewModel>>();
            using (HttpClient httpClient = new HttpClient())
            {
                HttpResponseMessage responseApı = await httpClient.GetAsync("http://localhost:4100/SerialTvs");
                string contentResponseApi = await responseApı.Content.ReadAsStringAsync();
                response = JsonSerializer.Deserialize<Response<List<SerialTvViewModel>>>(contentResponseApi);
            }
            return View(response.Data);
        }

        public async Task<IActionResult> UpdateIsActive(int id)
        {
            HttpClient httpClient = new HttpClient();

            HttpRequestMessage request = new HttpRequestMessage()
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri($"http://localhost:4100/SerialTvs/UpdateIsActive/{id}"),
                Content = new StringContent("", Encoding.UTF8, "application/json")
            };
            HttpResponseMessage response = await httpClient.SendAsync(request);

            return RedirectToAction("Index");
        }
    }
}
