




Console.WriteLine("Welcome to the lesson on Loops in C#!");
Console.WriteLine("Loops are a fundamental concept in programming that allow you to execute a block of code multiple times.");
Console.WriteLine("They are useful for tasks that require repetition, such as iterating over data, performing calculations, or automating repetitive tasks.");

// Why Learn Loops?
Console.WriteLine("\nWhy Learn Loops?");
Console.WriteLine("1. Loops help reduce code duplication.");
Console.WriteLine("2. They make your code more efficient and easier to maintain.");
Console.WriteLine("3. Loops are essential for working with collections, arrays, and data structures.");

// Types of Loops in C#
Console.WriteLine("\nTypes of Loops in C#:");
Console.WriteLine("1. For Loop");
Console.WriteLine("2. While Loop");
Console.WriteLine("3. Do-While Loop");
Console.WriteLine("4. Foreach Loop");

// Examples and Explanations

// 1. For Loop
Console.WriteLine("\nFor Loop Example:");
Console.WriteLine("The for loop is used when the number of iterations is known.");
Console.WriteLine("Syntax: for (initialization; condition; increment) { /* code */ }");
for (int i = 1; i <= 5; i++)
{
    Console.WriteLine($"Iteration {i}");
}

// 2. While Loop
Console.WriteLine("\nWhile Loop Example:");
Console.WriteLine("The while loop is used when the number of iterations is not known beforehand.");
Console.WriteLine("Syntax: while (condition) { /* code */ }");
int count = 1;
while (count <= 5)
{
    Console.WriteLine($"Count: {count}");
    count++;
}

// 3. Do-While Loop
Console.WriteLine("\nDo-While Loop Example:");
Console.WriteLine("The do-while loop is similar to the while loop, but it guarantees at least one execution of the code block.");
Console.WriteLine("Syntax: do { /* code */ } while (condition);");
int number = 1;
do
{
    Console.WriteLine($"Number: {number}");
    number++;
} while (number <= 5);

// 4. Foreach Loop
Console.WriteLine("\nForeach Loop Example:");
Console.WriteLine("The foreach loop is used to iterate over a collection or array.");
Console.WriteLine("Syntax: foreach (var item in collection) { /* code */ }");
string[] fruits = { "Apple", "Banana", "Cherry" };
foreach (string fruit in fruits)
{
    Console.WriteLine(fruit);
}

// Practice Exercises
Console.WriteLine("\nPractice Exercises:");

// Exercise 1: Print numbers from 1 to 10 using a for loop.
Console.WriteLine("Exercise 1: Use a for loop to print numbers from 1 to 10.");

// Exercise 2: Use a while loop to calculate the sum of numbers from 1 to 5.
Console.WriteLine("Exercise 2: Use a while loop to calculate the sum of numbers from 1 to 5.");

// Exercise 3: Use a do-while loop to display a menu until the user selects 'Exit'.
Console.WriteLine("Exercise 3: Use a do-while loop to display a menu until the user selects 'Exit'.");

// Exercise 4: Iterate through an array of colors and print each color using a foreach loop.
Console.WriteLine("Exercise 4: Use a foreach loop to iterate through an array of colors and print each color.");