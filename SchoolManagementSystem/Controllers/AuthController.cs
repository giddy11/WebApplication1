using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SchoolManagementSystem.Models;
using SchoolManagementSystem.Repositories;
using SchoolManagementSystem.Services;

namespace SchoolManagementSystem.Controllers
{
    // ===================================================================
    // AUTH CONTROLLER -- this is workshop Module 3 ("What Is Authentication?")
    // turned into real, running code.
    //
    //   POST /api/auth/signup -> create a brand-new account (like issuing
    //                            someone their very first passport)
    //   POST /api/auth/login  -> prove who you are with email + password,
    //                            and get back a JWT "wristband" to use on
    //                            every later request
    //
    // Notice this controller has NO [Authorize] attribute: you can't be
    // asked to prove who you are before you even have an account, or before
    // you've logged in for the first time (Module 7: authentication happens
    // first, and these two endpoints ARE that first step).
    // ===================================================================
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : Controller
    {
        private readonly IUserRepository _userRepository;
        private readonly IJwtTokenService _jwtTokenService;

        // PasswordHasher is the built-in ASP.NET Core tool that turns a plain
        // password into a safe, one-way hash, and later checks a guess
        // against that hash (Module 12: "Safe password storage" -- systems
        // never store your raw password). We never compare raw strings.
        private readonly PasswordHasher<User> _passwordHasher = new();

        public AuthController(IUserRepository userRepository, IJwtTokenService jwtTokenService)
        {
            _userRepository = userRepository;
            _jwtTokenService = jwtTokenService;
        }

        // POST: api/auth/signup
        [HttpPost("signup")]
        public async Task<ActionResult<AuthResponseDto>> Signup(SignupDto dto)
        {
            // --- Step 1: basic validation ---
            if (string.IsNullOrWhiteSpace(dto.Email) || string.IsNullOrWhiteSpace(dto.Password))
            {
                return BadRequest("Email and password are required.");
            }

            // --- Step 2: only allow one of our four known roles ---
            // This is what stops someone signing up as "SuperAdminHacker" by
            // simply typing it into the Role box (Module 12: "least privilege").
            if (!RoleNames.All.Contains(dto.Role))
            {
                return BadRequest($"Role must be one of: {string.Join(", ", RoleNames.All)}");
            }

            // --- Step 3: make sure nobody already signed up with this email ---
            var existingUser = await _userRepository.GetByEmailAsync(dto.Email);
            if (existingUser != null)
            {
                return BadRequest("An account with this email already exists.");
            }

            var user = new User
            {
                Name = dto.Name,
                Email = dto.Email,
                Role = dto.Role
            };

            // --- Step 4: hash the password before it ever touches the database ---
            user.PasswordHash = _passwordHasher.HashPassword(user, dto.Password);

            var created = await _userRepository.AddAsync(user);

            // Signing up logs you straight in, so we hand back a token immediately
            // instead of forcing a separate login call.
            var token = _jwtTokenService.CreateToken(created);

            return Ok(new AuthResponseDto
            {
                Id = created.Id,
                Name = created.Name,
                Email = created.Email,
                Role = created.Role,
                Token = token
            });
        }

        // POST: api/auth/login
        [HttpPost("login")]
        public async Task<ActionResult<AuthResponseDto>> Login(LoginDto dto)
        {
            // This mirrors Module 9's "Authentication Flow" exactly:
            //   1. User arrives            -> this HTTP request
            //   2. Enters login details    -> dto.Email / dto.Password
            //   3. Identity verified       -> the two checks below
            //   4. User recognised         -> we return a signed JWT

            var user = await _userRepository.GetByEmailAsync(dto.Email);
            if (user == null)
            {
                // Deliberately vague: we don't reveal whether the email exists,
                // only whether the *combination* of email + password is right.
                return Unauthorized("Invalid email or password.");
            }

            var verifyResult = _passwordHasher.VerifyHashedPassword(user, user.PasswordHash, dto.Password);
            if (verifyResult == PasswordVerificationResult.Failed)
            {
                return Unauthorized("Invalid email or password.");
            }

            var token = _jwtTokenService.CreateToken(user);

            return Ok(new AuthResponseDto
            {
                Id = user.Id,
                Name = user.Name,
                Email = user.Email,
                Role = user.Role,
                Token = token
            });
        }
    }
}
