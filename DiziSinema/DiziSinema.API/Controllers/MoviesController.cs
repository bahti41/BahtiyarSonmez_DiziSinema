using DiziSinema.Business.Absract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace DiziSinema.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private readonly IMovieService _movieManager;

        public MoviesController(IMovieService movieManager)
        {
            _movieManager = movieManager;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var response = await _movieManager.GetAllAsync();
            var jsonResponse = JsonSerializer.Serialize(response);
            return Ok(jsonResponse);
        }
    }
}
