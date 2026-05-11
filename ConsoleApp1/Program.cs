/*
    ============================================================================
    C# FUNDAMENTALS: CONDITIONAL STATEMENTS & LOOPS
    ============================================================================

    LESSON OVERVIEW:
    This lesson covers control flow in C#:
    - Conditional Statements (if, else if, else, switch)
    - Loops & Iteration (for, while, do-while, foreach)
    - Breaking down decision-making and repetition in code

    WHY ARE CONDITIONALS AND LOOPS IMPORTANT?
    - Conditionals: Allow programs to make decisions
    - Loops: Allow programs to repeat actions
    - Together: Enable dynamic, intelligent programs

    PREREQUISITE KNOWLEDGE:
    - Data types, variables, operators, and expressions
    ============================================================================
*/

Console.WriteLine("═══════════════════════════════════════════════════════════════════════");
Console.WriteLine("        C# CONDITIONAL STATEMENTS & LOOPS");
Console.WriteLine("═══════════════════════════════════════════════════════════════════════");
Console.WriteLine();

// ============================================================================
// PART 1: CONDITIONAL STATEMENTS
// ============================================================================

Console.WriteLine("╔═══════════════════════════════════════════════════════════════════════╗");
Console.WriteLine("║                    PART 1: CONDITIONAL STATEMENTS                    ║");
Console.WriteLine("╚═══════════════════════════════════════════════════════════════════════╝");
Console.WriteLine();

// ============================================================================
// SECTION 1: THE if STATEMENT
// ============================================================================


/*
    WHAT IS AN if STATEMENT?
    An if statement allows your program to make a decision.
    "If this condition is true, then do this."

    BASIC SYNTAX:
    if (condition)
    {
        // Code executes ONLY if condition is true
    }


    HOW IT WORKS:
    1. The program evaluates the condition (true or false)
    2. If true: Executes the code inside the braces {}
    3. If false: Skips the code and continues

    CONDITION:
    - Must be a boolean expression (something that evaluates to true/false)
    - Uses comparison operators: ==, !=, <, >, <=, >=
    - Uses logical operators: &&, ||, !

    EXAMPLE 1: Simple age check
    if (age >= 18)
    {
        Console.WriteLine("You are an adult");
    }

    EXAMPLE 2: Multiple conditions
    if (age >= 18 && hasLicense)
    {
        Console.WriteLine("You can drive");
    }

    IMPORTANT POINTS:
    - Braces {} are optional for single statements but HIGHLY RECOMMENDED
    - The condition is always in parentheses ()
    - The code inside braces only runs if condition is true
    - After the if block, code continues normally
*/

Console.WriteLine("--- SECTION 1: THE if STATEMENT ---");
Console.WriteLine();

// Example 1: Simple if
int studentScore = 85;
if (studentScore >= 60)
{
    Console.WriteLine($"✓ Score {studentScore} is passing! You passed the exam.");
}

Console.WriteLine();

// Example 2: if with &&
int studentAge = 20;
bool hasPermission = true;

if (studentAge >= 18 && hasPermission)
{
    Console.WriteLine($"✓ Age {studentAge} and has permission: Can attend the event");
}

Console.WriteLine();

// Example 3: if that doesn't execute
int balance = 50;
if (balance > 1000)
{
    Console.WriteLine("You have plenty of money");
}
// This block doesn't execute because balance (50) is NOT > 1000

Console.WriteLine($"Balance: ${balance} (if condition was false, so no message printed)");
Console.WriteLine();

// ============================================================================
// SECTION 2: THE if-else STATEMENT
// ============================================================================

/*
    WHAT IS if-else?
    The if-else statement provides TWO paths:
    - If condition is true: Execute one block
    - If condition is false: Execute the other block

    "If this is true, do this. Otherwise (else), do that."

    SYNTAX:
    if (condition)
    {
        // Executes if condition is TRUE
    }
    else
    {
        // Executes if condition is FALSE
    }

    FLOW:
    - Program checks the condition
    - If true: Executes the if block, then skips the else block
    - If false: Skips the if block, executes the else block
    - Only ONE of the two blocks ever executes

    EXAMPLE:
    if (age >= 18)
    {
        Console.WriteLine("You are an adult");
    }
    else
    {
        Console.WriteLine("You are a minor");
    }

    Either the first message or the second message prints, never both.

    USE CASES:
    - Validation (Valid/Invalid)
    - Binary decisions (Yes/No, Pass/Fail)
    - Toggling features (On/Off)
*/

Console.WriteLine("--- SECTION 2: THE if-else STATEMENT ---");
Console.WriteLine();

// Example 1: Age classification
int personAge = 15;
if (personAge >= 18)
{
    Console.WriteLine($"Age {personAge}: You are an adult");
}
else
{
    Console.WriteLine($"Age {personAge}: You are a minor");
}

Console.WriteLine();

// Example 2: Grade pass/fail
int examScore = 55;
if (examScore >= 60)
{
    Console.WriteLine($"Score {examScore}: PASSED ✓");
}
else
{
    Console.WriteLine($"Score {examScore}: FAILED ✗");
}

Console.WriteLine();

// Example 3: Even/Odd number
int number = 7;
if (number % 2 == 0)
{
    Console.WriteLine($"{number} is EVEN");
}
else
{
    Console.WriteLine($"{number} is ODD");
}

Console.WriteLine();

// ============================================================================
// SECTION 3: THE if-else if-else STATEMENT
// ============================================================================

// 90 - 100 - A
// 75 - 89 - B
// 50 - 74 - C
// < 50 - F
//string name = "Tolu";
//int score = -900;

//if (score >= 90 && score <= 100)
//{
//    Console.WriteLine($"{name} grade is A");
//}
//else if (score >= 75 && score <= 89)
//{
//    Console.WriteLine($"{name} grade is B");
//}
//else if (score >= 50 && score <= 74)
//{
//    Console.WriteLine($"{name} grade is C");
//}
//else if (score >= 0 && score < 50)
//{
//    Console.WriteLine($"{name} grade is F");
//}
//else
//{
//    Console.WriteLine("Invalid Score");
//}

//Console.WriteLine("The End.");

/*
    WHAT IS if-else if-else?
    When you need to check MULTIPLE conditions, use else if.
    "If this is true, do this. Else if that is true, do that. Else do this."

    SYNTAX:
    if (condition1)
    {
        // Executes if condition1 is TRUE
    }
    else if (condition2)
    {
        // Executes if condition1 is FALSE and condition2 is TRUE
    }
    else if (condition3)
    {
        // Executes if condition1 and condition2 are FALSE and condition3 is TRUE
    }
    else
    {
        // Executes if ALL conditions above are FALSE
    }

    FLOW:
    - Program checks condition1
    - If true: Execute first block, skip all others
    - If false: Check condition2
    - If condition2 true: Execute second block, skip others
    - If condition2 false: Check condition3
    - And so on...
    - If all are false: Execute the final else block

    IMPORTANT:
    - Only ONE block executes (the first one that evaluates to true)
    - The else block is optional
    - You can have many else if blocks
    - Order matters! First matching condition wins

    EXAMPLE: Grade letter assignment
    if (score >= 90)
    {
        Console.WriteLine("A");  // 90-100
    }
    else if (score >= 80)
    {
        Console.WriteLine("B");  // 80-89
    }
    else if (score >= 70)
    {
        Console.WriteLine("C");  // 70-79
    }
    else if (score >= 60)
    {
        Console.WriteLine("D");  // 60-69
    }
    else
    {
        Console.WriteLine("F");  // Below 60
    }
*/

Console.WriteLine("--- SECTION 3: THE if-else if-else STATEMENT ---");
Console.WriteLine();

// Example 1: Grade letter assignment
//int score = 85;
//string grade = "";

//if (score >= 90)
//{
//    grade = "A";
//}
//else if (score >= 80)
//{
//    grade = "B";
//}
//else if (score >= 70)
//{
//    grade = "C";
//}
//else if (score >= 60)
//{
//    grade = "D";
//}
//else
//{
//    grade = "F";
//}

//Console.WriteLine($"Score: {score} → Grade: {grade}");
//Console.WriteLine();

//// Example 2: Time of day greeting
//int hour = 14;
//string timeGreeting = "";

if (hour < 12)
{
    timeGreeting = "Good morning! ☀️";
}
else if (hour < 17)
{
    timeGreeting = "Good afternoon! 🌤️";
}
else if (hour < 21)
{
    timeGreeting = "Good evening! 🌙";
}
else
{
    timeGreeting = "Good night! 😴";
}

//Console.WriteLine($"Time: {hour}:00 → {timeGreeting}");
//Console.WriteLine();

// Example 3: Age category
//int personAge_3 = 25;
//string category = "";

//if (personAge_3 < 13)
//{
//    category = "Child";
//}
//else if (personAge_3 < 18)
//{
//    category = "Teenager";
//}
//else if (personAge_3 < 65)
//{
//    category = "Adult";
//}
//else
//{
//    category = "Senior";
//}

//Console.WriteLine($"Age {personAge_3}: {category}");
Console.WriteLine();

// ============================================================================
// SECTION 4: NESTED if STATEMENTS
// ============================================================================

//If user's age above 18years; If that user has a drivers licence
//int userAge1 = 19;
//bool hasLicence = true;

//if (userAge1 >= 18)
//{
//    if (hasLicence)
//    {
//        Console.WriteLine("1.This user is above 18 and has a licence");
//    }
    
//}

//if (userAge1 >= 18 && hasLicence)
//{
//    Console.WriteLine("2.This user is above 18 and has a licence");
//}

/*
    WHAT ARE NESTED if STATEMENTS?
    An if statement inside another if statement.
    Used when a decision depends on a previous decision.

    "If this is true, then check if that is also true."

    SYNTAX:
    if (outerCondition)
    {
        if (innerCondition)
        {
            // Executes only if BOTH conditions are true
        }
    }

    WHEN TO USE:
    - When you need multiple conditions to all be true
    - Alternative: Use && (AND) operator instead

    Example with nesting:
    if (age >= 18)
    {
        if (hasLicense)
        {
            Console.WriteLine("Can drive");
        }
    }

    Same logic using &&:
    if (age >= 18 && hasLicense)
    {
        Console.WriteLine("Can drive");
    }

    Usually, using && is cleaner and more readable than nesting.
    Use nesting only when it makes the logic clearer.
*/

Console.WriteLine("--- SECTION 4: NESTED if STATEMENTS ---");
Console.WriteLine();

int userAge = 20;
bool hasValidID = true;
double accountBalance = 500;

// Nested if
if (userAge >= 18)
{
    if (hasValidID)
    {
        if (accountBalance >= 100)
        {
            Console.WriteLine("✓ Can make the purchase (nested if approach)");
        }
    }
}

Console.WriteLine();

// Same logic using && (cleaner)
if (userAge >= 18 && hasValidID && accountBalance >= 100)
{
    Console.WriteLine("✓ Can make the purchase (using && approach - cleaner!)");
}

Console.WriteLine();

// Nested if with else
int customerAge = 17;
if (customerAge >= 18)
{
    Console.WriteLine("You are an adult");
}
else
{
    if (customerAge >= 13)
    {
        Console.WriteLine("You are a teenager");
    }
    else
    {
        Console.WriteLine("You are a child");
    }
}

Console.WriteLine();

// ============================================================================
// SECTION 5: THE switch STATEMENT
// ============================================================================

/*
    WHAT IS A switch STATEMENT?
    The switch statement is used when you have ONE variable that can have
    MANY possible values, and you want different code for each value.

    "Based on this value, do this different action for each case."

    ANALOGY:
    Think of a switch like a remote control or menu:
    - Press 1: Channel 1
    - Press 2: Channel 2
    - Press 3: Channel 3
    - Default: Channel not found

    SYNTAX:
    switch (expression)
    {
        case value1:
            // Code if expression == value1
            break;
        case value2:
            // Code if expression == value2
            break;
        default:
            // Code if no cases match
            break;
    }

    COMPONENTS:
    - switch (expression): The variable being tested
    - case value: Checks if expression equals value
    - break: Exits the switch block
    - default: Executes if no cases match (like else)

    IMPORTANT:
    - break is ESSENTIAL! Without it, code "falls through" to next case
    - default is optional but recommended for handling unexpected values
    - Each case should compare to a specific value
    - More efficient than many else if statements

    EXAMPLE: Menu selection
    switch (menuChoice)
    {
        case 1:
            Console.WriteLine("New Game");
            break;
        case 2:
            Console.WriteLine("Load Game");
            break;
        case 3:
            Console.WriteLine("Settings");
            break;
        default:
            Console.WriteLine("Invalid choice");
            break;
    }

    SWITCH vs if-else if:
    - Use switch when checking ONE variable against MANY values
    - Use if-else if when checking DIFFERENT variables or complex conditions
    - switch is often cleaner and faster for multiple values
*/

//Console.WriteLine("--- SECTION 5: THE switch STATEMENT ---");
//Console.WriteLine();

// Example 1: Day of week
int dayNumber = 3;
string dayName = "";

switch (dayNumber)
{
    case 1:
        dayName = "Monday";
        break;
    case 2:
        dayName = "Tuesday";
        break;
    case 3:
        dayName = "Wednesday";
        break;
    case 4:
        dayName = "Thursday";
        break;
    case 5:
        dayName = "Friday";
        break;
    case 6:
        dayName = "Saturday";
        break;
    case 7:
        dayName = "Sunday";
        break;
    default:
        dayName = "Invalid day";
        break;
}

//Console.WriteLine($"Day {dayNumber}: {dayName}");
//Console.WriteLine();

// Example 2: Simple calculator
int num1 = 10;
int num2 = 5;
char operation = '+';
int result = 0;

switch (operation)
{
    case '+':
        result = num1 + num2;
        break;
    case '-':
        result = num1 - num2;
        break;
    case '*':
        result = num1 * num2;
        break;
    case '/':
        result = num1 / num2;
        break;
    default:
        //Console.WriteLine("Invalid operation");
        break;
}

//Console.WriteLine($"{num1} {operation} {num2} = {result}");
//Console.WriteLine();

// Example 3: Grade feedback
char letterGrade = 'B';
string feedback = "";

switch (letterGrade)
{
    case 'A':
        feedback = "Excellent! Outstanding performance! 🌟";
        break;
    case 'B':
        feedback = "Good! Well done! 👍";
        break;
    case 'C':
        feedback = "Fair! Average performance. Try harder next time.";
        break;
    case 'D':
        feedback = "Poor! Below average. Study more!";
        break;
    case 'F':
        feedback = "Fail! Need significant improvement.";
        break;
    default:
        feedback = "Unknown grade";
        break;
}

//Console.WriteLine($"Grade {letterGrade}: {feedback}");
//Console.WriteLine();

// ============================================================================
// PART 2: LOOPS & ITERATION
// ============================================================================

Console.WriteLine();
Console.WriteLine("╔═══════════════════════════════════════════════════════════════════════╗");
Console.WriteLine("║                     PART 2: LOOPS & ITERATION                         ║");
Console.WriteLine("╚═══════════════════════════════════════════════════════════════════════╝");
Console.WriteLine();

// ============================================================================
// SECTION 6: THE for LOOP
// ============================================================================

/*
    WHAT IS A for LOOP?
    A loop that repeats a block of code a SPECIFIC number of times.
    "Repeat this code 5 times" or "Repeat this for each number from 1 to 10"

    SYNTAX:
    for (initialization; condition; increment)
    {
        // Code to repeat
    }

    COMPONENTS:
    1. INITIALIZATION: Set starting value (int i = 0;)
       - Runs only ONCE before the loop starts
       - Creates the loop variable

    2. CONDITION: Determines when to keep looping (i < 5;)
       - Checked before EACH iteration
       - If true: Loop continues
       - If false: Loop stops

    3. INCREMENT: Happens after EACH iteration (i++)
       - Usually increases the loop variable
       - i++ means "add 1 to i"

    FLOW:
    for (int i = 0; i < 3; i++)
    {
        Console.WriteLine(i);  // Prints: 0, then 1, then 2
    }

    Step-by-step:
    1. i = 0 (initialize)
    2. Check: 0 < 3? YES → print 0
    3. i++ (now i = 1)
    4. Check: 1 < 3? YES → print 1
    5. i++ (now i = 2)
    6. Check: 2 < 3? YES → print 2
    7. i++ (now i = 3)
    8. Check: 3 < 3? NO → STOP loop

    COMMON PATTERNS:
    for (int i = 1; i <= 10; i++)    // 1 to 10
    for (int i = 10; i >= 1; i--)   // 10 down to 1
    for (int i = 0; i < array.Length; i++)  // Through array

    LOOP VARIABLE (i):
    - i is just a variable name (can be any name)
    - Usually i, j, k for loop counters
    - Only exists inside the loop
*/

Console.WriteLine("--- SECTION 6: THE for LOOP ---");
Console.WriteLine();

// Example 1: Simple counting loop
//Console.WriteLine("Example 1: Count from 1 to 5");
//for (int i = 1; i <= 5; i++)
//{
//    Console.WriteLine($"Count: {i}");
//}

Console.WriteLine();

// Example 2: Print multiplication table
//Console.WriteLine("Example 2: Multiplication table of 5");
//int num = 5;
//for (int i = 1; i <= 10; i++)
//{
//    Console.WriteLine($"5 × {i} = {num * i}");
//}

Console.WriteLine();

//// Example 3: Countdown
//Console.WriteLine("Example 3: Countdown from 5 to 1");
//for (int i = 5; i >= 1; i--)
//{
//    Console.WriteLine($"...{i}");
//}
//Console.WriteLine("🚀 Blastoff!");

//Console.WriteLine();

//// Example 4: Sum numbers 1 to 10
//Console.WriteLine("Example 4: Sum numbers 1 to 10");
//int sum = 0;
//for (int i = 1; i <= 10; i++)
//{
//    sum += i;  // sum = sum + i
//}
//Console.WriteLine($"Sum of 1 to 10: {sum}");

//Console.WriteLine();

// ============================================================================
// SECTION 7: THE while LOOP
// ============================================================================

/*
    WHAT IS A while LOOP?
    A loop that repeats while a condition is TRUE.
    "Keep repeating this code as long as this condition is true"

    SYNTAX:
    while (condition)
    {
        // Code to repeat
    }

    HOW IT WORKS:
    1. Check the condition
    2. If true: Execute code, go back to step 1
    3. If false: Exit loop

    EXAMPLE:
    int count = 0;
    while (count < 3)
    {
        Console.WriteLine(count);  // Prints: 0, 1, 2
        count++;
    }

    FLOW:
    - Check: 0 < 3? YES → print 0, increment count
    - Check: 1 < 3? YES → print 1, increment count
    - Check: 2 < 3? YES → print 2, increment count
    - Check: 3 < 3? NO → EXIT loop

    DIFFERENCE FROM for:
    - for: Use when you know HOW MANY times to loop
    - while: Use when you don't know when to stop

    WHEN TO USE while:
    - Reading input until user enters "quit"
    - Processing data until a condition is met
    - Waiting for something to happen
    - Unknown number of iterations

    INFINITE LOOP WARNING:
    A loop with a condition that's always true runs forever!

    Bad example (infinite loop):
    while (true)
    {
        Console.WriteLine("This never stops!");
    }

    BEST PRACTICES:
    - Always ensure the loop variable changes inside the loop
    - Otherwise, condition never becomes false, and loop never stops
*/

Console.WriteLine("--- SECTION 7: THE while LOOP ---");
Console.WriteLine();

// Example 1: Simple while loop
//Console.WriteLine("Example 1: While loop counting");
//int counter = 1;
//while (counter <= 5)
//{
//    Console.WriteLine($"Counter: {counter}");
//    counter++;
//}

//Console.WriteLine();

//// Example 2: User input simulation (password attempts)
//Console.WriteLine("Example 2: Password verification (simulated)");
//int attempts = 0;
//int maxAttempts = 3;

//// Simulating user attempts
//string[] passwords = { "wrong", "incorrect", "secret123" };

//while (attempts < maxAttempts)
//{
//    string enteredPassword = passwords[attempts];

//    if (enteredPassword == "secret123")
//    {
//        Console.WriteLine($"✓ Attempt {attempts + 1}: Correct! Access granted.");
//        break;  // Exit the loop early
//    }
//    else
//    {
//        Console.WriteLine($"✗ Attempt {attempts + 1}: Incorrect password.");
//    }

//    attempts++;
//}

//if (attempts == maxAttempts)
//{
//    Console.WriteLine("❌ Maximum attempts exceeded. Access denied.");
//}

Console.WriteLine();

// Example 3: Sum until negative
//Console.WriteLine("Example 3: Sum numbers until negative input (simulated)");
//int[] numbers_to_sum = { 5, 10, 15, -1 };
//int index = 0;
//int total_sum = 0;

//while (index < numbers_to_sum.Length && numbers_to_sum[index] >= 0)
//{
//    total_sum += numbers_to_sum[index];
//    Console.WriteLine($"Added {numbers_to_sum[index]}, Total: {total_sum}");
//    index++;
//}
//Console.WriteLine($"Negative number found: {numbers_to_sum[index]}, stopping.");
//Console.WriteLine($"Final sum: {total_sum}");

Console.WriteLine();

// ============================================================================
// SECTION 8: THE do-while LOOP
// ============================================================================

/*
    WHAT IS A do-while LOOP?
    A loop that executes at least ONCE, then repeats while a condition is true.
    "Do this once, then keep doing it while condition is true"

    SYNTAX:
    do
    {
        // Code to repeat (runs at least once!)
    } while (condition);

    IMPORTANT: Note the semicolon at the end!

    DIFFERENCE FROM while:
    - while: Checks condition BEFORE running code
    - do-while: Runs code FIRST, then checks condition
    - This means do-while code runs AT LEAST ONCE

    EXAMPLE:
    int num = 0;
    do
    {
        Console.WriteLine(num);  // Runs at least once!
        num++;
    } while (num < 3);  // Then checks condition

    FLOW:
    - Execute code (num = 0, print 0, num++)
    - Check: 1 < 3? YES → repeat
    - Execute code (num = 1, print 1, num++)
    - Check: 2 < 3? YES → repeat
    - Execute code (num = 2, print 2, num++)
    - Check: 3 < 3? NO → EXIT

    WHEN TO USE do-while:
    - Input validation (ask user, check, ask again if invalid)
    - Menu systems (show menu, get choice, show menu again)
    - Game loops (run game once, ask "play again?")
    - Any situation where code must run at least once

    REAL-WORLD EXAMPLE: Menu system
    do
    {
        Console.WriteLine("1. New Game");
        Console.WriteLine("2. Load Game");
        Console.WriteLine("3. Exit");
        string choice = Console.ReadLine();

        // Process choice
    } while (choice != "3");  // Keep showing menu until user exits
*/

//Console.WriteLine("--- SECTION 8: THE do-while LOOP ---");
//Console.WriteLine();

//// Example 1: Simple do-while
//Console.WriteLine("Example 1: Do-while loop (runs at least once)");
//int count = 0;
//do
//{
//    Console.WriteLine($"Iteration: {count}");
//    count++;
//} while (count < 3);

//Console.WriteLine();

//// Example 2: Menu system simulation
//Console.WriteLine("Example 2: Menu system (simulated)");
//string[] menu_choices = { "1", "3", "2", "0" };
//int menu_index = 0;
//string user_choice = "";

//do
//{
//    Console.WriteLine("═══ MAIN MENU ═══");
//    Console.WriteLine("1. Start Game");
//    Console.WriteLine("2. Settings");
//    Console.WriteLine("3. Exit");

//    user_choice = menu_choices[menu_index];
//    Console.WriteLine($"You selected: {user_choice}");

//    switch (user_choice)
//    {
//        case "1":
//            Console.WriteLine("→ Starting game...");
//            break;
//        case "2":
//            Console.WriteLine("→ Opening settings...");
//            break;
//        case "3":
//            Console.WriteLine("→ Exiting game...");
//            break;
//        default:
//            Console.WriteLine("→ Invalid choice");
//            break;
//    }

//    Console.WriteLine();
//    menu_index++;

//} while (user_choice != "3" && menu_index < menu_choices.Length);

Console.WriteLine();

// Example 3: Input validation
//Console.WriteLine("Example 3: Number validation (simulated)");
//int[] input_attempts = { 5, -2, 0, 15 };
//int input_index = 0;
//int validated_number = 0;

//do
//{
//    validated_number = input_attempts[input_index];

//    if (validated_number > 0 && validated_number <= 10)
//    {
//        Console.WriteLine($"✓ Valid number: {validated_number}");
//        break;
//    }
//    else
//    {
//        Console.WriteLine($"✗ Invalid number: {validated_number}. Must be 1-10. Try again.");
//    }

//    input_index++;
//} while (input_index < input_attempts.Length);

//Console.WriteLine();

// ============================================================================
// SECTION 9: THE foreach LOOP
// ============================================================================

/*
    WHAT IS A foreach LOOP?
    A loop that goes through each item in a collection.
    "For each item in this list, do something with it"

    SYNTAX:
    foreach (dataType variable in collection)
    {
        // Code using variable
    }

    COMPONENTS:
    - dataType: The type of items in the collection
    - variable: Represents the current item
    - collection: The list/array to loop through

    EXAMPLE:
    string[] fruits = { "Apple", "Banana", "Orange" };
    foreach (string fruit in fruits)
    {
        Console.WriteLine(fruit);
    }

    Output:
    Apple
    Banana
    Orange

    HOW IT WORKS:
    - First iteration: fruit = "Apple"
    - Second iteration: fruit = "Banana"
    - Third iteration: fruit = "Orange"
    - Done!

    WHEN TO USE:
    - Arrays: foreach (int num in array)
    - Lists: foreach (string item in list)
    - When you don't need the index
    - When you want simple, readable code

    DIFFERENCE FROM for:
    - for: You control the counter, can skip or go backwards
    - foreach: Automatically goes through each item in order
    - foreach: Can't easily modify the collection during iteration

    ARRAYS (Quick reminder):
    - Array: Collection of same-type values
    - Syntax: dataType[] name = { value1, value2, value3 };
    - Example: int[] numbers = { 1, 2, 3, 4, 5 };
    - Access: numbers[0] gets first item
    - Length: numbers.Length gets count
*/

Console.WriteLine("--- SECTION 9: THE foreach LOOP ---");
Console.WriteLine();

// Example 1: Loop through array of strings
Console.WriteLine("Example 1: Loop through colors");
string[] colors = { "Red", "Green", "Blue", "Yellow", "Purple" };

foreach (string color in colors)
{
    Console.WriteLine($"Color: {color}");
}

Console.WriteLine();

// Example 2: Loop through array of numbers
//Console.WriteLine("Example 2: Loop through numbers and sum them");
//int[] scores = { 85, 92, 78, 95, 88 };
//int total = 0;

//foreach (int score in scores)
//{
//    total += score;
//    Console.WriteLine($"Score: {score}, Total so far: {total}");
//}

//Console.WriteLine($"Average: {total / scores.Length}");
//Console.WriteLine();

//// Example 3: String characters
//Console.WriteLine("Example 3: Loop through characters in a string");
//string text = "HELLO";

//foreach (char letter in text)
//{
//    Console.WriteLine($"Letter: {letter}");
//}

Console.WriteLine();

// Example 4: Finding maximum value
Console.WriteLine("Example 4: Find the highest score");
int[] exam_scores = { 75, 92, 88, 85, 95, 82 };
int highest = exam_scores[0];  // Start with first score

foreach (int exam_score in exam_scores)
{
    if (exam_score > highest)
    {
        highest = exam_score;
    }
}

Console.WriteLine($"Scores: {string.Join(", ", exam_scores)}");
Console.WriteLine($"Highest score: {highest}");

Console.WriteLine();

// ============================================================================
// SECTION 10: BREAK AND CONTINUE
// ============================================================================

/*
    WHAT ARE break AND continue?
    Two keywords that control loop behavior:

    BREAK:
    - Exits the loop immediately
    - Used when you want to stop looping early
    - Works with: for, while, do-while, foreach

    Syntax:
    for (int i = 0; i < 10; i++)
    {
        if (i == 5)
            break;  // Exit loop when i = 5
        Console.WriteLine(i);  // Prints: 0, 1, 2, 3, 4
    }

    CONTINUE:
    - Skips the current iteration
    - Jumps to the next iteration
    - Works with: for, while, do-while, foreach

    Syntax:
    for (int i = 0; i < 10; i++)
    {
        if (i == 5)
            continue;  // Skip when i = 5
        Console.WriteLine(i);  // Prints: 0, 1, 2, 3, 4, 6, 7, 8, 9
    }

    COMPARISON:
    break:       Stop loop entirely
    continue:    Skip current iteration, continue with next

    USE CASES FOR break:
    - Found what you're looking for (stop searching)
    - Error occurred (exit loop)
    - User wants to stop
    - Maximum attempts reached

    USE CASES FOR continue:
    - Skip invalid data
    - Skip even/odd numbers
    - Skip duplicate items
    - Skip based on condition

    EXAMPLE: Search for item
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == target)
        {
            Console.WriteLine("Found!");
            break;  // Stop searching
        }
    }

    EXAMPLE: Skip even numbers
    for (int i = 1; i <= 10; i++)
    {
        if (i % 2 == 0)
            continue;  // Skip even numbers
        Console.WriteLine(i);  // Prints: 1, 3, 5, 7, 9
    }
*/

Console.WriteLine("--- SECTION 10: BREAK AND CONTINUE ---");
Console.WriteLine();

// Example 1: break - Search for value
Console.WriteLine("Example 1: BREAK - Find a specific number");
int[] numbersArray = { 10, 20, 30, 40, 50, 60, 70 };
int searchFor = 40;
int searchIndex = -1;

for (int i = 0; i < numbersArray.Length; i++)
{
    if (numbersArray[i] == searchFor)
    {
        searchIndex = i;
        Console.WriteLine($"✓ Found {searchFor} at index {searchIndex}");
        break;  // Stop searching immediately
    }
}

if (searchIndex == -1)
{
    Console.WriteLine($"✗ {searchFor} not found");
}

Console.WriteLine();

// Example 2: continue - Skip even numbers
Console.WriteLine("Example 2: CONTINUE - Print only odd numbers from 1 to 10");
for (int i = 1; i <= 10; i++)
{
    if (i % 2 == 0)
    {
        continue;  // Skip even numbers, go to next iteration
    }
    Console.WriteLine($"Odd: {i}");
}

Console.WriteLine();

// Example 3: break in while loop
Console.WriteLine("Example 3: BREAK - Stop after finding password");
string[] password_attempts = { "weak", "medium", "strong123", "excellent" };
bool found = false;

foreach (string attempt in password_attempts)
{
    if (attempt.Length >= 8)
    {
        Console.WriteLine($"✓ Strong password found: {attempt}");
        found = true;
        break;  // Stop checking
    }
    else
    {
        Console.WriteLine($"✗ Weak password: {attempt}");
    }
}

Console.WriteLine();

// Example 4: continue in foreach
Console.WriteLine("Example 4: CONTINUE - Sum only positive numbers");
int[] mixed_numbers = { 5, -3, 8, -1, 10, 2, -5 };
int positive_sum = 0;

foreach (int num in mixed_numbers)
{
    if (num < 0)
    {
        continue;  // Skip negative numbers
    }
    positive_sum += num;
    Console.WriteLine($"Added: {num}, Sum: {positive_sum}");
}

Console.WriteLine($"Final sum of positive numbers: {positive_sum}");

Console.WriteLine();

// ============================================================================
// SECTION 11: PRACTICAL EXAMPLES - COMBINING CONDITIONALS & LOOPS
// ============================================================================

Console.WriteLine("--- SECTION 11: PRACTICAL EXAMPLES ---");
Console.WriteLine();

// Example 1: Grade analyzer
Console.WriteLine("Example 1: Grade Analyzer");
int[] student_grades = { 92, 78, 85, 91, 88, 76, 95 };
int grade_count = 0;
int grade_sum = 0;
int max_grade = student_grades[0];
int min_grade = student_grades[0];

foreach (int g in student_grades)
{
    grade_sum += g;
    grade_count++;

    if (g > max_grade)
        max_grade = g;

    if (g < min_grade)
        min_grade = g;
}

double average_grade = (double)grade_sum / grade_count;

Console.WriteLine($"Grades: {string.Join(", ", student_grades)}");
Console.WriteLine($"Average: {average_grade:F2}");
Console.WriteLine($"Highest: {max_grade}");
Console.WriteLine($"Lowest: {min_grade}");
Console.WriteLine();

// Example 2: FizzBuzz (classic programming exercise)
Console.WriteLine("Example 2: FizzBuzz (1-15)");
for (int i = 1; i <= 15; i++)
{
    if (i % 15 == 0)
    {
        Console.WriteLine("FizzBuzz");
    }
    else if (i % 3 == 0)
    {
        Console.WriteLine("Fizz");
    }
    else if (i % 5 == 0)
    {
        Console.WriteLine("Buzz");
    }
    else
    {
        Console.WriteLine(i);
    }
}

Console.WriteLine();

// Example 3: Multiplication table grid
Console.WriteLine("Example 3: Multiplication Table (4x4)");
for (int i = 1; i <= 4; i++)
{
    for (int j = 1; j <= 4; j++)
    {
        Console.Write($"{i * j,3} ");  // Right-aligned in 3 spaces
    }
    Console.WriteLine();
}

Console.WriteLine();

// Example 4: Find prime numbers
Console.WriteLine("Example 4: Prime Numbers from 2 to 20");
for (int num = 2; num <= 20; num++)
{
    bool isPrime = true;

    for (int divisor = 2; divisor < num; divisor++)
    {
        if (num % divisor == 0)
        {
            isPrime = false;
            break;
        }
    }

    if (isPrime)
    {
        Console.WriteLine($"{num} is prime");
    }
}

Console.WriteLine();

// ============================================================================
// SECTION 12: COMMON MISTAKES & BEST PRACTICES
// ============================================================================

/*
    COMMON MISTAKE #1: Infinite loops (forgetting to update loop variable)
    while (true)  // Always true!
    {
        Console.WriteLine("Never stops!");
    }

    COMMON MISTAKE #2: Off-by-one errors
    Wrong:  for (int i = 0; i <= 10; i++)  // Goes 0 to 10 (11 iterations!)
    Right:  for (int i = 0; i < 10; i++)   // Goes 0 to 9 (10 iterations)

    COMMON MISTAKE #3: Using break in nested loops (only breaks inner loop)
    for (int i = 0; i < 3; i++)
    {
        for (int j = 0; j < 3; j++)
        {
            if (j == 1)
                break;  // Only breaks inner loop, outer continues!
        }
    }

    COMMON MISTAKE #4: Forgetting semicolon in do-while
    do { ... } while (condition)  // WRONG!
    do { ... } while (condition);  // RIGHT!

    COMMON MISTAKE #5: Modifying loop variable inside loop (confusing)
    for (int i = 0; i < 10; i++)
    {
        i += 2;  // Skips numbers in unpredictable way
    }

    BEST PRACTICES:

    1. Use meaningful loop variable names
       Good: for (int studentIndex = 0; ...)
       Bad:  for (int i = 0; ...)

    2. Use the right loop for the job
       - for: When you know the count
       - while: When you don't know when to stop
       - do-while: When code must run at least once
       - foreach: When looping through a collection

    3. Keep loops simple
       - Complex logic inside loops is hard to debug
       - Consider extracting to methods

    4. Avoid deeply nested loops
       - Hard to understand
       - Slow performance

    5. Use clear conditions
       Good: while (count < maxAttempts)
       Bad:  while (count < 5 && !cancelled && valid)
*/

Console.WriteLine("--- SECTION 12: COMMON MISTAKES ---");
Console.WriteLine();
Console.WriteLine("Mistake examples (not executed to avoid issues):");
Console.WriteLine();
Console.WriteLine("❌ MISTAKE #1: Infinite loop");
Console.WriteLine("   while (true) { ... }");
Console.WriteLine();
Console.WriteLine("❌ MISTAKE #2: Off-by-one error");
Console.WriteLine("   for (int i = 0; i <= 10; i++)  // Should use i < 10");
Console.WriteLine();
Console.WriteLine("❌ MISTAKE #3: Forgetting semicolon in do-while");
Console.WriteLine("   do { ... } while (condition)  // Missing semicolon!");
Console.WriteLine();
Console.WriteLine("✅ BEST PRACTICE: Clear, simple loops");
Console.WriteLine("   for (int i = 0; i < 10; i++)  // Clear intent");
Console.WriteLine();

// ============================================================================
// MINI CHALLENGES
// ============================================================================

Console.WriteLine("═══════════════════════════════════════════════════════════════════════");
Console.WriteLine("                       MINI CHALLENGES");
Console.WriteLine("═══════════════════════════════════════════════════════════════════════");
Console.WriteLine();

// Challenge 1: Simple number checker
Console.WriteLine("Challenge 1: Number Checker");
int num_to_check = 7;
if (num_to_check % 2 == 0)
{
    Console.WriteLine($"{num_to_check} is EVEN");
}
else
{
    Console.WriteLine($"{num_to_check} is ODD");
}

if (num_to_check > 5)
{
    Console.WriteLine("Number is greater than 5");
}

Console.WriteLine();

// Challenge 2: Factorial calculation
Console.WriteLine("Challenge 2: Calculate 5! (5 factorial)");
int factorial_num = 5;
int factorial_result = 1;

for (int i = 1; i <= factorial_num; i++)
{
    factorial_result *= i;
}

Console.WriteLine($"{factorial_num}! = {factorial_result}");

Console.WriteLine();

// Challenge 3: Count specific grade
Console.WriteLine("Challenge 3: Count A grades in array");
char[] grades = { 'A', 'B', 'A', 'C', 'A', 'B', 'D' };
int a_count = 0;

foreach (char grade in grades)
{
    if (grade == 'A')
    {
        a_count++;
    }
}

Console.WriteLine($"Total A grades: {a_count} out of {grades.Length}");

Console.WriteLine();

// Challenge 4: Reverse array
Console.WriteLine("Challenge 4: Print array in reverse");
int[] array_to_reverse = { 10, 20, 30, 40, 50 };
Console.Write("Reversed: ");

for (int i = array_to_reverse.Length - 1; i >= 0; i--)
{
    Console.Write($"{array_to_reverse[i]} ");
}
Console.WriteLine();

Console.WriteLine();

// Challenge 5: Pattern printing
Console.WriteLine("Challenge 5: Print a triangle pattern");
for (int i = 1; i <= 5; i++)
{
    for (int j = 0; j < i; j++)
    {
        Console.Write("★ ");
    }
    Console.WriteLine();
}

Console.WriteLine();

// ============================================================================
// LESSON SUMMARY
// ============================================================================

Console.WriteLine("═══════════════════════════════════════════════════════════════════════");
Console.WriteLine("                      LESSON SUMMARY");
Console.WriteLine("═══════════════════════════════════════════════════════════════════════");
Console.WriteLine();

Console.WriteLine("CONDITIONAL STATEMENTS:");
Console.WriteLine("✓ if: Execute if true");
Console.WriteLine("✓ if-else: Two paths (true or false)");
Console.WriteLine("✓ if-else if-else: Multiple conditions");
Console.WriteLine("✓ switch: Check one variable against many values");
Console.WriteLine("✓ Nested if: One condition inside another");
Console.WriteLine();

Console.WriteLine("LOOPS:");
Console.WriteLine("✓ for: Known number of iterations");
Console.WriteLine("✓ while: Repeat while condition is true");
Console.WriteLine("✓ do-while: Run once, then repeat while true");
Console.WriteLine("✓ foreach: Loop through each item in a collection");
Console.WriteLine();

Console.WriteLine("LOOP CONTROL:");
Console.WriteLine("✓ break: Exit loop immediately");
Console.WriteLine("✓ continue: Skip to next iteration");
Console.WriteLine();

Console.WriteLine("KEY RULES:");
Console.WriteLine("1. Always use braces {} even for single statements");
Console.WriteLine("2. Indent code for readability");
Console.WriteLine("3. Use meaningful variable names");
Console.WriteLine("4. Test edge cases (empty, one item, many items)");
Console.WriteLine("5. Avoid infinite loops");
Console.WriteLine();

Console.WriteLine("WHEN TO USE WHAT:");
Console.WriteLine("─ Two choices → if-else");
Console.WriteLine("─ Many choices → switch");
Console.WriteLine("─ Known iterations → for");
Console.WriteLine("─ Unknown iterations → while");
Console.WriteLine("─ Loop through collection → foreach");
Console.WriteLine();

Console.WriteLine("NEXT LESSONS:");
Console.WriteLine("→ Methods and Functions");
Console.WriteLine("→ Arrays and Collections");
Console.WriteLine("→ Object-Oriented Programming");
Console.WriteLine("→ Exception Handling");
Console.WriteLine();

Console.WriteLine("═══════════════════════════════════════════════════════════════════════");
Console.WriteLine("      CONGRATULATIONS! YOU'VE MASTERED CONDITIONALS & LOOPS! 🎉");
Console.WriteLine("═══════════════════════════════════════════════════════════════════════");
