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
        // IConfiguration is how ASP.NET Core hands us values from
        // appsettings.json. We ask it for anything under the "Jwt" section
        // (Issuer, Audience, Key, ExpiryMinutes) further down.
        private readonly IConfiguration _config;

        // ASP.NET Core's dependency injection container creates this class
        // for us and automatically passes in the app's configuration here --
        // we never call "new JwtTokenService(...)" ourselves anywhere.
        public JwtTokenService(IConfiguration config)
        {
            _config = config;
        }

        // Called once, right after a successful signup or login (see
        // AuthController). Everything in this method happens locally --
        // no database call, no network call -- it just builds and signs a
        // piece of text.
        public string CreateToken(User user)
        {
            // --- STEP 1: decide what facts to bake into the token ---
            // A "claim" is just a small labelled fact about the user, stored
            // as text inside the token. Once the token is signed (Step 3),
            // these facts can be trusted on every later request without
            // asking the database again.
            var claims = new List<Claim>
            {
                // "Sub" (Subject) is the standard JWT claim for "whose token
                // is this?". We store the user's database Id here.
                new Claim(JwtRegisteredClaimNames.Sub, user.Id.ToString()),

                new Claim(JwtRegisteredClaimNames.Email, user.Email),

                // ClaimTypes.Name is a .NET-specific claim type; it's what
                // shows up as User.Identity.Name in controllers, if you ever
                // need to display "logged in as ___".
                new Claim(ClaimTypes.Name, user.Name),

                // This is the important one for this workshop: ASP.NET
                // Core's [Authorize(Roles = "...")] attribute looks
                // specifically for a claim of type ClaimTypes.Role. Whatever
                // string we put here (Student/Teacher/Principal/Accountant)
                // is what gets checked later (Module 10: Authorization Flow,
                // step 3 "permission check").
                new Claim(ClaimTypes.Role, user.Role)
            };

            // --- STEP 2: load the shared secret from appsettings.json ---
            // Encoding.UTF8.GetBytes turns the Key string into raw bytes,
            // because the signing algorithm below works on bytes, not text.
            // SymmetricSecurityKey just wraps those bytes so the JWT library
            // recognises them as "a key to sign/verify with".
            var keyBytes = Encoding.UTF8.GetBytes(_config["Jwt:Key"]!);
            var signingKey = new SymmetricSecurityKey(keyBytes);

            // "Symmetric" means the SAME key both creates the signature here
            // AND checks it later in Program.cs -- unlike, say, a physical
            // signature where only one specific person can produce it. This
            // is exactly why Jwt:Key must stay secret: anyone with it could
            // sign their own fake tokens the same way we do here.
            //
            // HmacSha256 is the specific mixing formula ("algorithm") used
            // to combine the key + the token's contents into that signature.
            var credentials = new SigningCredentials(signingKey, SecurityAlgorithms.HmacSha256);

            // --- STEP 3: work out when this token should stop being valid ---
            // Reads Jwt:ExpiryMinutes from appsettings.json (falls back to 60
            // if it's ever missing). Program.cs's ValidateLifetime check is
            // what actually enforces this expiry on incoming requests.
            var expiryMinutes = double.Parse(_config["Jwt:ExpiryMinutes"] ?? "60");

            // --- STEP 4: assemble and sign the token ---
            // This builds the token object in memory: WHO created it
            // (issuer), WHO it's meant for (audience), WHAT facts it carries
            // (claims), WHEN it expires, and finally signingCredentials --
            // passing that in is what actually stamps the signature onto it.
            var token = new JwtSecurityToken(
                issuer: _config["Jwt:Issuer"],
                audience: _config["Jwt:Audience"],
                claims: claims,
                expires: DateTime.UtcNow.AddMinutes(expiryMinutes),
                signingCredentials: credentials
            );

            // --- STEP 5: turn the token object into the actual string ---
            // JwtSecurityToken above is just a .NET object describing the
            // token; WriteToken() serialises it into the long
            // "xxxxx.yyyyy.zzzzz" string format that gets sent to the client
            // and later shows up in the "Authorization: Bearer <token>"
            // header on every request.
            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
