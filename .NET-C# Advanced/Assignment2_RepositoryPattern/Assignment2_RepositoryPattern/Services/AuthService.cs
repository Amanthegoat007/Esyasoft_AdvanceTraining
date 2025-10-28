using Assignment2_RepositoryPattern.Models;
using Assignment2_RepositoryPattern.Repositories;
using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Assignment2_RepositoryPattern.Services
{
    public class AuthService : IAuthService
    {
        private readonly IUserRepository _userRepository;
        private readonly IConfiguration _configuration;
        private readonly IPasswordHasher<User> _passwordHasher;

        public AuthService(IUserRepository userRepository, IConfiguration configuration, IPasswordHasher<User> passwordHasher)
        {
            _userRepository = userRepository;
            _configuration = configuration;
            _passwordHasher = passwordHasher;
        }

        public async Task<(bool Succeeded, string? Token, string? Error)> AuthenticateAsync(string username, string password)
        {
            var user = await _userRepository.GetByUserNameAsync(username);
            if (user == null) return (false, null, "Invalid username or password.");

            var verifyResult = _passwordHasher.VerifyHashedPassword(user, user.Password, password);
            if (verifyResult == PasswordVerificationResult.Failed)
                return (false, null, "Invalid username or password.");

            // Generate JWT
            var jwtSettings = _configuration.GetSection("Jwt");
            var key = jwtSettings["Key"] ?? throw new InvalidOperationException("Jwt:Key not configured");
            var issuer = jwtSettings["Issuer"];
            var audience = jwtSettings["Audience"];
            var duration = int.TryParse(jwtSettings["DurationInMinutes"], out var m) ? m : 60;

            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, user.UserName),
                new Claim(ClaimTypes.NameIdentifier, user.UserId.ToString()),
                new Claim(ClaimTypes.Role, user.Role ?? "User")
            };

            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(key));
            var creds = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            var tokenDescriptor = new JwtSecurityToken(
                issuer: issuer,
                audience: audience,
                claims: claims,
                expires: DateTime.UtcNow.AddMinutes(duration),
                signingCredentials: creds
            );

            var token = new JwtSecurityTokenHandler().WriteToken(tokenDescriptor);

            return (true, token, null);
        }

        public async Task<(bool Succeeded, string? Error)> RegisterAsync(string username, string password, string role = "User")
        {
            var existing = await _userRepository.GetByUserNameAsync(username);
            if (existing != null) return (false, "User already exists");

            var user = new User
            {
                UserName = username,
                Role = role
            };

            user.Password = _passwordHasher.HashPassword(user, password); // hashed

            await _userRepository.AddAsync(user);
            return (true, null);
        }
    }
}
