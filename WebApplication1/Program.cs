using WebApplication1;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddSingleton<IMyService, MyService>(); // Register MyService as a singleton service

var app = builder.Build();

app.Use(async (context, next) =>
{
    var myService = context.RequestServices.GetRequiredService<IMyService>(); // Resolve the service from the request services
    myService.LogCreation("Handling incoming request - First Middleware");
    await next.Invoke();
});

app.Use(async (context, next) =>
{
    var myService = context.RequestServices.GetRequiredService<IMyService>();
    myService.LogCreation("Handling incoming request - Second Middleware");
    await next.Invoke();
});

app.UseHttpLogging(); // Add the HTTP logging middleware to the request pipeline
app.MapGet("/", (IMyService myService) =>
{
    myService.LogCreation("Handling request to root endpoint");
    return Results.Ok("Check the console for service creation logs");
});

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();