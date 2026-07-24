using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.IdentityModel.Tokens;
using SchoolManagementSystem.Models;

namespace SchoolManagementSystem.Services
{
    // ===================================================================
    // Builds the JWT ("JSON Web Token") that proves a user already logged in.
    //
    // Workshop Module 9 (Authentication Flow), step 4 is "user recognised" --
    // but HTTP is stateless, so the app needs a way to stay "recognised" on
    // every later request without asking for the password again. A JWT is
    // that reusable proof: it's a signed piece of text containing the user's
    // Id, Name and Role (called "claims"). The client stores it and sends it
    // back as "Authorization: Bearer <token>" on every request. Because it is
    // cryptographically signed with our secret Jwt:Key, the server can trust
    // the claims inside it without touching the database or the password again.
    //
    // Those claims -- especially the Role claim -- are exactly what
    // [Authorize(Roles = "...")] checks later (Module 10: Authorization Flow,
    // step 3 "permission check").
    // ===================================================================
    public class JwtTokenService : IJwtTokenService
    {
        private readonly IConfiguration _config;

        public JwtTokenService(IConfiguration config)
        {
            _config = config;
        }

        public string CreateToken(User user)
        {
            var claims = new List<Claim>
            {
                new Claim(JwtRegisteredClaimNames.Sub, user.Id.ToString()),
                new Claim(JwtRegisteredClaimNames.Email, user.Email),
                new Claim(ClaimTypes.Name, user.Name),
                // This is the claim ASP.NET Core reads for [Authorize(Roles = "...")].
                new Claim(ClaimTypes.Role, user.Role)
            };

            var keyBytes = Encoding.UTF8.GetBytes(_config["Jwt:Key"]!);
            var signingKey = new SymmetricSecurityKey(keyBytes);
            var credentials = new SigningCredentials(signingKey, SecurityAlgorithms.HmacSha256);

            var expiryMinutes = double.Parse(_config["Jwt:ExpiryMinutes"] ?? "60");

            var token = new JwtSecurityToken(
                issuer: _config["Jwt:Issuer"],
                audience: _config["Jwt:Audience"],
                claims: claims,
                expires: DateTime.UtcNow.AddMinutes(expiryMinutes),
                signingCredentials: credentials
            );

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
