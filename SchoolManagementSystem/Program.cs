using System.Text;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using SchoolManagementSystem.Data;
using SchoolManagementSystem.Repositories;
using SchoolManagementSystem.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();

// Teach Swagger UI about our JWT so you can click "Authorize", paste in the
// token you got from POST /api/auth/login, and Swagger will attach it to
// every request for you (as "Authorization: Bearer <token>").
builder.Services.AddSwaggerGen(options =>
{
    options.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
    {
        Name = "Authorization",
        Type = SecuritySchemeType.Http,
        Scheme = "Bearer",
        BearerFormat = "JWT",
        In = ParameterLocation.Header,
        Description = "Paste the token from POST /api/auth/login here (no need to type 'Bearer ' first)."
    });
    options.AddSecurityRequirement(new OpenApiSecurityRequirement
    {
        {
            new OpenApiSecurityScheme
            {
                Reference = new OpenApiReference { Type = ReferenceType.SecurityScheme, Id = "Bearer" }
            },
            Array.Empty<string>()
        }
    });
});

// Add the ef core and sql server db context
builder.Services.AddDbContext<SchoolDbContext>(options => options.UseSqlServer("Data Source=(localdb)\\ProjectModels;Initial Catalog=SchoolManagementDB;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False;Command Timeout=30"));

builder.Services.AddScoped<IDepartmentRepository, DepartmentRepository>();
builder.Services.AddScoped<IStudentRepository, StudentRepository>();
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<IJwtTokenService, JwtTokenService>();

// =====================================================================
// AUTHENTICATION (workshop Module 3): this tells ASP.NET Core HOW to
// check "who are you?" on every request. We're using JWT Bearer tokens:
// the client sends "Authorization: Bearer <token>" (the token it got back
// from POST /api/auth/login), and this middleware checks the token's
// signature, issuer, audience and expiry -- instead of asking for the
// password again on every single request.
// =====================================================================
builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(options =>
    {
        // These are the checks run on every incoming JWT before ASP.NET Core
        // will trust it and treat the request as "authenticated". If ANY of
        // them fails, the request is rejected with 401 Unauthorized and
        // [Authorize] never even gets a user to check roles against.
        options.TokenValidationParameters = new TokenValidationParameters
        {
            // Issuer = "who created this token?" Must match the "iss" value
            // JwtTokenService baked into the token (Jwt:Issuer below), so a
            // token minted by some other app can't be reused here.
            ValidateIssuer = true,
            ValidIssuer = builder.Configuration["Jwt:Issuer"],

            // Audience = "who was this token created for?" Must match the
            // "aud" value in the token (Jwt:Audience), so a token meant for a
            // different API can't be replayed against this one.
            ValidateAudience = true,
            ValidAudience = builder.Configuration["Jwt:Audience"],

            // Signature check = "was this token tampered with?" We re-sign
            // the token's contents with our secret Jwt:Key and compare. If
            // even one character in the token changed, the signatures won't
            // match and it's rejected -- this is what stops someone editing
            // their own Role claim from "Student" to "Principal" by hand.
            ValidateIssuerSigningKey = true,
            IssuerSigningKey = new SymmetricSecurityKey(
                Encoding.UTF8.GetBytes(builder.Configuration["Jwt:Key"]!)),

            // Expiry check = "has this token gone stale?" JwtTokenService set
            // an "exp" (expiry) claim when it created the token
            // (Jwt:ExpiryMinutes controls how long that window is); this
            // rejects the token once that time has passed.
            ValidateLifetime = true,
            // Normally a small "grace period" (a few minutes) is allowed past
            // expiry, to cover clock differences between servers. We're
            // running everything on one machine for this workshop, so we set
            // it to zero: expiry means expiry, no extra leeway.
            ClockSkew = TimeSpan.Zero
        };
    });

// AUTHORIZATION (workshop Module 6): now that ASP.NET Core knows HOW to
// authenticate a request, this switches on the [Authorize] and
// [Authorize(Roles = "...")] checks used on the controllers below.
builder.Services.AddAuthorization();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

// IMPORTANT: order matters here, and it matches Module 7's "Order" row --
// authentication happens first, authorization happens second.
// UseAuthentication() figures out WHO is calling (reads and validates the JWT).
// UseAuthorization() then decides WHAT that caller is allowed to do.
// Swap these two lines and [Authorize] would have no identity to check yet.
app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();


//1. AddTransient
//2. AddScoped
//3. AddSingleton