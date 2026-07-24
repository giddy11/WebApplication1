using SchoolManagementSystem.Models;

namespace SchoolManagementSystem.Repositories
{
    public interface IUserRepository : IRepository<User>
    {
        // Login looks a user up by email (not by Id), so we need this one
        // extra method on top of the generic IRepository<T> CRUD methods.
        Task<User?> GetByEmailAsync(string email);
    }
}
