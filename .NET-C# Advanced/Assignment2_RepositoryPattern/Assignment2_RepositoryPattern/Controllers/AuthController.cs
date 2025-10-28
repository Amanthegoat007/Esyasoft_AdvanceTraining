using Assignment2_RepositoryPattern.DTOs;
using Assignment2_RepositoryPattern.Services;
using Microsoft.AspNetCore.Mvc;

namespace Assignment2_RepositoryPattern.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;
        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register(UserRegisterDto dto)
        {
            var (succeeded, error) = await _authService.RegisterAsync(dto.UserName, dto.Password, dto.Role);
            if (!succeeded) return BadRequest(new { message = error });
            return Ok(new { message = "User registered" });
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login(UserLoginDto dto)
        {
            var (succeeded, token, error) = await _authService.AuthenticateAsync(dto.UserName, dto.Password);
            if (!succeeded) return Unauthorized(new { message = error });
            return Ok(new { token });
        }
    }
}
