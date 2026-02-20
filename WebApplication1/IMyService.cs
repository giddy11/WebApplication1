namespace WebApplication1;

public interface IMyService
{
    void LogCreation(string message);
}

public class MyService : IMyService
{
    private readonly int _serviceId;
    public MyService()
    {
        _serviceId = new Random().Next(100000, 999999); // Generate a random 6-digit number
        Console.WriteLine($"MyService instance created with ID: {_serviceId}");
    }
    public void LogCreation(string message)
    {
        Console.WriteLine($"Service ID: [{_serviceId}] - Message: {message}");
    }
}