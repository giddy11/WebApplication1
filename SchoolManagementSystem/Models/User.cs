namespace SchoolManagementSystem.Models
{
    // ===================================================================
    // USER (workshop Module 8: "Users, Roles & Permissions")
    //
    // This is the account someone logs in with. Signing up / logging in
    // (Module 3: Authentication) answers "who are you?". The Role field is
    // what later answers "what are you allowed to do?" (Module 6: Authorization).
    // ===================================================================
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;

        // We NEVER store the raw password (Module 12: "Safe password storage").
        // Only this one-way hash is kept -- see AuthController, which uses
        // ASP.NET Core's built-in PasswordHasher to create and check it.
        public string PasswordHash { get; set; } = string.Empty;

        // One of RoleNames.Student / Teacher / Principal / Accountant.
        public string Role { get; set; } = string.Empty;
    }

    // -------------------------------------------------------------------
    // DTOs ("Data Transfer Objects") for the Auth endpoints.
    //
    // We use separate classes here instead of the User entity directly so
    // that things like PasswordHash can never accidentally be sent back to
    // (or read from) the client.
    // -------------------------------------------------------------------

    // What the client sends to POST /api/auth/signup
    public class SignupDto
    {
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;

        // Must be one of RoleNames.All -- checked in AuthController.Signup.
        public string Role { get; set; } = string.Empty;
    }

    // What the client sends to POST /api/auth/login
    public class LoginDto
    {
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
    }

    // What we send back after a successful signup or login: enough to show
    // a welcome screen, plus the JWT "wristband" the client must attach to
    // every later request that needs authentication.
    public class AuthResponseDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Role { get; set; } = string.Empty;
        public string Token { get; set; } = string.Empty;
    }
}
