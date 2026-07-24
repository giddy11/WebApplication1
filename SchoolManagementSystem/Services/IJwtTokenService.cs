using SchoolManagementSystem.Models;

namespace SchoolManagementSystem.Services
{
    public interface IJwtTokenService
    {
        // Turns a logged-in User into a signed JWT string.
        string CreateToken(User user);
    }
}
