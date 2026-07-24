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
        options.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuer = true,
            ValidIssuer = builder.Configuration["Jwt:Issuer"],

            ValidateAudience = true,
            ValidAudience = builder.Configuration["Jwt:Audience"],

            ValidateIssuerSigningKey = true,
            IssuerSigningKey = new SymmetricSecurityKey(
                Encoding.UTF8.GetBytes(builder.Configuration["Jwt:Key"]!)),

            ValidateLifetime = true,
            ClockSkew = TimeSpan.Zero // don't allow extra grace time after the token expires
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