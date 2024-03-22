using DiziSinema.Business.Absract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace DiziSinema.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GenresController : ControllerBase
    {
        private readonly IGenreService _genreManager;

        public GenresController(IGenreService genreManager)
        {
            _genreManager = genreManager;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var response = await _genreManager.GetAllAsync();
            var jsonSerilaz = JsonSerializer.Serialize(response);
            return Ok(jsonSerilaz);
        }
    }
}
