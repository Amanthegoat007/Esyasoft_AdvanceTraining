using Assignment2_RepositoryPattern.Models;
using Microsoft.EntityFrameworkCore;

namespace Assignment2_RepositoryPattern.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly EmployeeDbContext _context;
        public UserRepository(EmployeeDbContext context)
        {
            _context = context;
        }

        public async Task<User?> GetByUserNameAsync(string username)
        {
            return await _context.Users.SingleOrDefaultAsync(u => u.UserName == username);
        }

        public async Task AddAsync(User user)
        {
            _context.Users.Add(user);
            await _context.SaveChangesAsync();
        }
    }
}
