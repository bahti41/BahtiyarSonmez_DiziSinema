using DiziSinema.Business.Concrete;
using DiziSinema.Entity.Concrete.Identity;
using DiziSinema.Shared.DTOs;
using DiziSinema.Shared.DTOs.Idenetity;
using DiziSinema.Shared.ReponseDTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace DiziSinema.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;

        public AccountController(UserManager<User> userManager, SignInManager<User> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        [HttpPost("Register")]
        public async Task<IActionResult> Register(RegisterDTO registerDTO)
        {
            User user = new User
            {
                UserName = registerDTO.UserName,
                Email = registerDTO.Email,
                FirstName = registerDTO.FirstName,
                LastName = registerDTO.LastName,
            };

            var result = await _userManager.CreateAsync(user, registerDTO.Password);
            var jsonSerilaz = JsonSerializer.Serialize(result);
            return Ok(jsonSerilaz);
        }

        [HttpGet("FindByName")]
        public async Task<IActionResult> FindByNameAsync(LoginDTO loginDTO)
        {
            User user = await _userManager.FindByNameAsync(loginDTO.UserName);
            var jsonSerilaz = JsonSerializer.Serialize(user);
            return Ok(jsonSerilaz);
        }

        [HttpGet("PasswordSignIn")]
        public async Task<IActionResult> PasswordSignInAsync(User user, LoginDTO loginDTO, bool isPersistent, bool lockoutonFailure)
        {
            var result = await _signInManager.PasswordSignInAsync(user, loginDTO.Password, false, false);
            var jsonSerilaz = JsonSerializer.Serialize(result);
            return Ok(jsonSerilaz);
        }

        [HttpGet("Logout")]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return Ok();
        }
    }
}