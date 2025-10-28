using Assignment2_RepositoryPattern.Models;

namespace Assignment2_RepositoryPattern.Repositories
{
    public interface IUserRepository
    {
        Task<User?> GetByUserNameAsync(string username);
        Task AddAsync(User user);
    }
}
