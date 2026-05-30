
//Creating the instance of the Car class
using ConsoleApp1;

int number = 5;

List<string> students =  new List<string>();

Car car1 = new Car();
Car car2 = new Car();

//Modifying or writing to the property
car1.Brand = "Toyota";
car1.Color = "Red";
car1.Speed = 40;

car2.Brand = "Camry";
car2.Color = "Ash";
car2.Speed = 0;

// Reading the data or property
Console.WriteLine(car1.Brand);

// Calling the method of a class
car1.Accelerate();
car1.Accelerate();
car1.Accelerate();
car1.Accelerate();
car1.Accelerate();

Console.WriteLine($"The car1 speed is: {car1.Speed}");
Console.WriteLine($"The car1 speed is: {car2.Speed}");


