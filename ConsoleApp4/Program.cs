
//1. User enters a number

//Without exception handling:

//Console.WriteLine("Enter your age: ");
//int age = int.Parse(Console.ReadLine());

//Console.WriteLine($"You are {age} years old.");

//With Exception Handling:

//try
//{
//    Console.WriteLine("Enter your age: ");
//    int age = int.Parse(Console.ReadLine());
//}
//catch (FormatException)
//{
//    Console.WriteLine("Please enter a valid number.");
//}

//2. Divide by Zero
//try
//{
//    Console.WriteLine("Enter a number: ");
//    int number = int.Parse(Console.ReadLine());

//    int result = 100 / number;

//    Console.WriteLine($"Result: {result}");
//}
//catch (DivideByZeroException)
//{
//    Console.WriteLine("You cannot divide by zero.");
//}

//3. Multiple Catch Blocks
//try
//{
//    Console.WriteLine("Enter a number: ");
//    int number = int.Parse(Console.ReadLine());

//    int result = 100 / number;

//    Console.WriteLine($"Result: {result}");
//}
//catch (FormatException)
//{
//    Console.WriteLine("Please enter a valid number.");
//}
//catch (DivideByZeroException)
//{
//    Console.WriteLine("You cannot divide by zero.");
//}

//4. Generic Exception Catch
try
{
    Console.WriteLine("Enter a number: ");
    int number = int.Parse(Console.ReadLine());

    int result = 100 / number;

    Console.WriteLine($"Result: {result}");
}
catch (Exception ex)
{
    Console.WriteLine($"An error occured: {ex.Message}");
}