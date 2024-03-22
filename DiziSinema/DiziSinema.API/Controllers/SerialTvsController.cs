using DiziSinema.Business.Absract;
using DiziSinema.Business.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace DiziSinema.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class SerialTvsController : ControllerBase
    {
        private readonly ISerialTvSevice _serialTvManager;

        public SerialTvsController(ISerialTvSevice serialTvManager)
        {
            _serialTvManager = serialTvManager;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var response = await _serialTvManager.GetAllAsync();
            var jsonResponse = JsonSerializer.Serialize(response);
            return Ok(jsonResponse);
        }
    }
}
