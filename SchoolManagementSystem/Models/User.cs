namespace SchoolManagementSystem.Models
{
    public class User
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? PasswordHash { get; set; }
        public string? Role { get; set; }
    }

    public class SignupDto
    {
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? Role { get; set; }
    }

    public class LoginDto
    {
        public string? Email { get; set; }
        public string? Role { get; set; }
    }

    public class AuthResponseDto
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? Role { get; set; }
        public string? Token {  get; set; }
    }
}
