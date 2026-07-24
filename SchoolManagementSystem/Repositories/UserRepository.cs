using Microsoft.EntityFrameworkCore;
using SchoolManagementSystem.Data;
using SchoolManagementSystem.Models;

namespace SchoolManagementSystem.Repositories
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        private readonly SchoolDbContext _context;

        public UserRepository(SchoolDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<User?> GetByEmailAsync(string email)
        {
            // Emails should be treated as case-insensitive ("A@B.com" == "a@b.com"),
            // so we compare lower-cased versions on both sides.
            return await _context.Users
                .FirstOrDefaultAsync(u => u.Email.ToLower() == email.ToLower());
        }
    }
}
