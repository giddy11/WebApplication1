/*
    ============================================================================
    C# FUNDAMENTALS: LOOPS
    ============================================================================

    LESSON OVERVIEW:
    This lesson covers the concept of loops in C#:
    - What are loops?
    - Types of loops (for, while, do-while, foreach)
    - Practical examples and use cases

    WHY ARE LOOPS IMPORTANT?
    - Loops allow programs to repeat actions efficiently.
    - They reduce code duplication and improve maintainability.
    - Essential for working with collections, arrays, and repetitive tasks.

    PREREQUISITE KNOWLEDGE:
    - Data types, variables, operators, and expressions
    ============================================================================
*/

Console.WriteLine("═══════════════════════════════════════════════════════════════════════");
Console.WriteLine("        C# LOOPS: FOR, WHILE, DO-WHILE, FOREACH");
Console.WriteLine("═══════════════════════════════════════════════════════════════════════");
Console.WriteLine();

// ============================================================================
// PART 1: INTRODUCTION TO LOOPS
// ============================================================================

Console.WriteLine("╔═══════════════════════════════════════════════════════════════════════╗");
Console.WriteLine("║                    PART 1: INTRODUCTION TO LOOPS                     ║");
Console.WriteLine("╚═══════════════════════════════════════════════════════════════════════╝");
Console.WriteLine();

Console.WriteLine("WHAT ARE LOOPS?");
Console.WriteLine("Loops are constructs that allow you to repeat a block of code multiple times.");
Console.WriteLine("They are useful for tasks like iterating over data, performing calculations, or automating repetitive actions.");
Console.WriteLine();

Console.WriteLine("TYPES OF LOOPS IN C#:");
Console.WriteLine("1. For Loop");
Console.WriteLine("2. While Loop");
Console.WriteLine("3. Do-While Loop");
Console.WriteLine("4. Foreach Loop");
Console.WriteLine();

// ============================================================================
// PART 2: EXAMPLES OF LOOPS
// ============================================================================

Console.WriteLine("╔═══════════════════════════════════════════════════════════════════════╗");
Console.WriteLine("║                    PART 2: EXAMPLES OF LOOPS                         ║");
Console.WriteLine("╚═══════════════════════════════════════════════════════════════════════╝");
Console.WriteLine();

// 1. For Loop
Console.WriteLine("--- FOR LOOP ---");
Console.WriteLine("The for loop is used when the number of iterations is known.");
Console.WriteLine("Example: Counting from 1 to 5");
for (int i = 1; i <= 5; i++)
{
    Console.WriteLine($"Iteration {i}");
}
Console.WriteLine();

// 2. While Loop
Console.WriteLine("--- WHILE LOOP ---");
Console.WriteLine("The while loop is used when the number of iterations is not known beforehand.");
Console.WriteLine("Example: Counting until a condition is met");
int count = 1;
while (count <= 5)
{
    Console.WriteLine($"Count: {count}");
    count++;
}
Console.WriteLine();

// 3. Do-While Loop
Console.WriteLine("--- DO-WHILE LOOP ---");
Console.WriteLine("The do-while loop guarantees at least one execution of the code block.");
Console.WriteLine("Example: Counting from 1 to 5");
int number = 1;
do
{
    Console.WriteLine($"Number: {number}");
    number++;
} while (number <= 5);
Console.WriteLine();

// 4. Foreach Loop
Console.WriteLine("--- FOREACH LOOP ---");
Console.WriteLine("The foreach loop is used to iterate over a collection or array.");
Console.WriteLine("Example: Iterating through an array of fruits");
string[] fruits = { "Apple", "Banana", "Cherry" };
foreach (string fruit in fruits)
{
    Console.WriteLine(fruit);
}
Console.WriteLine();

// ============================================================================
// PART 3: PRACTICE EXERCISES
// ============================================================================

Console.WriteLine("╔═══════════════════════════════════════════════════════════════════════╗");
Console.WriteLine("║                    PART 3: PRACTICE EXERCISES                        ║");
Console.WriteLine("╚═══════════════════════════════════════════════════════════════════════╝");
Console.WriteLine();

Console.WriteLine("EXERCISE 1: Use a for loop to print numbers from 1 to 10.");
Console.WriteLine("EXERCISE 2: Use a while loop to calculate the sum of numbers from 1 to 5.");
Console.WriteLine("EXERCISE 3: Use a do-while loop to display a menu until the user selects 'Exit'.");
Console.WriteLine("EXERCISE 4: Use a foreach loop to iterate through an array of colors and print each color.");
Console.WriteLine();

// ============================================================================
// LESSON SUMMARY
// ============================================================================

Console.WriteLine("═══════════════════════════════════════════════════════════════════════");
Console.WriteLine("                      LESSON SUMMARY");
Console.WriteLine("═══════════════════════════════════════════════════════════════════════");
Console.WriteLine();

Console.WriteLine("✓ Loops allow efficient repetition of code.");
Console.WriteLine("✓ Types of loops: for, while, do-while, foreach.");
Console.WriteLine("✓ Use the appropriate loop based on the task.");
Console.WriteLine();

Console.WriteLine("NEXT STEPS:");
Console.WriteLine("→ Practice writing loops for different scenarios.");
Console.WriteLine("→ Explore nested loops and advanced use cases.");
Console.WriteLine();

Console.WriteLine("═══════════════════════════════════════════════════════════════════════");
Console.WriteLine("      CONGRATULATIONS! YOU'VE MASTERED LOOPS IN C#! 🎉");
Console.WriteLine("═══════════════════════════════════════════════════════════════════════");