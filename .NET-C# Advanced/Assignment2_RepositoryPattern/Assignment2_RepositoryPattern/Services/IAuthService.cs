namespace Assignment2_RepositoryPattern.Services
{
    public interface IAuthService
    {
        Task<(bool Succeeded, string? Token, string? Error)> AuthenticateAsync(string username, string password);
        Task<(bool Succeeded, string? Error)> RegisterAsync(string username, string password, string role = "User");
    }
}
