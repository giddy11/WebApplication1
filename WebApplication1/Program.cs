using WebApplication1;

var builder = WebApplication.CreateBuilder(args);

//THE BUILDER HELPS TO CHANGE THE configuration of the application, such as adding services, setting up logging, and configuring middleware. It is used to create an instance of the WebApplication class, which represents the application itself. The builder pattern allows for a more flexible and modular way to configure the application before it is built and run.
// Add services to the container.

builder.Services.AddHttpLogging(options =>
{
    options.LoggingFields = Microsoft.AspNetCore.HttpLogging.HttpLoggingFields.All;
    options.RequestBodyLogLimit = 4096; // Limit the size of the logged request body
    options.ResponseBodyLogLimit = 4096; // Limit the size of the logged response body
});

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Register MyService as a singleton service in the dependency injection container. This means that the same instance of MyService will be used throughout the application's lifetime, and it will be created only once when it is first requested.
builder.Services.AddSingleton<IMyService, MyService>(); // Register MyService as a singleton service

var app = builder.Build();

//app.Use(async (context, next) =>
//{
//    var myService = context.RequestServices.GetRequiredService<IMyService>();
//    // Log the incoming request
//    Console.WriteLine($"Incoming request: {context.Request.Method} {context.Request.Path}");
//    myService.LogCreation("Handling incoming request - First Middleware");
//    // Call the next middleware in the pipeline
//    await next.Invoke();
//    // Log the outgoing response
//    //Console.WriteLine($"Outgoing response: {context.Response.StatusCode}");
//    //myService.LogCreation("Handled outgoing response");
//});

//app.Use(async (context, next) =>
//{
//    var myService = context.RequestServices.GetRequiredService<IMyService>();
//    myService.LogCreation("Handling incoming request - Second Middleware");
//    await next.Invoke();
//});

//app.MapGet("/", (IMyService service) =>
//{
//    service.LogCreation("Handling request to root endpoint");
//    return Results.Ok("Check the console for service creation logs");
//});

app.UseHttpLogging(); // Add the HTTP logging middleware to the request pipeline
//app.MapGet("/", () => "Hello World!");
//app.Use(async (context, next) =>
//{
//    // Log the incoming request
//    Console.WriteLine($"Incoming request: {context.Request.Method} {context.Request.Path}");
//    // Call the next middleware in the pipeline
//    await next.Invoke();
//    // Log the outgoing response
//    Console.WriteLine($"Outgoing response: {context.Response.StatusCode}");
//});

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