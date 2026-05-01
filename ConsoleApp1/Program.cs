/*
    
============================================================================
    C# BEGINNERS: KODECAMP 6.0
    ============================================================================

============================================================================
    C# FUNDAMENTALS: DATA TYPES & VARIABLES
    ============================================================================

    LESSON OVERVIEW:
    This lesson covers the fundamental concepts of data types and variables in C#.
    By the end, students will understand how to declare, initialize, and use
    different data types to store and manipulate information.

    ============================================================================
*/

// ============================================================================
// SECTION 1: INTRODUCTION TO C# AND CONSOLE APPS
// ============================================================================

/*
    WHAT IS C#?
    - C# is a modern, object-oriented programming language
    - Developed by Microsoft
    - Part of the .NET ecosystem (framework for building applications)
    - Used for: Web applications, desktop apps, games, mobile apps, etc.

    WHAT IS A CONSOLE APP?
    - A console app is a program that runs in a text-based interface (terminal/command prompt)
    - No graphical buttons or windows—just text input and output
    - Perfect for learning programming basics

    THE Main METHOD:
    - Entry point of a console application
    - Code inside Main() executes first when the program runs
    - Everything starts here!
*/

// This is the entry point of our program
Console.WriteLine("========== C# DATA TYPES & VARIABLES LESSON ==========");
Console.WriteLine();

// ============================================================================
// SECTION 2: WHAT ARE DATA TYPES?
// ============================================================================

/*
    DEFINITION:
    A data type is a classification that specifies:
    - How much memory a variable uses
    - What kind of values it can store
    - What operations can be performed on it

    WHY DATA TYPES MATTER:
    1. MEMORY EFFICIENCY: Different types use different amounts of memory
    2. CORRECTNESS: Type safety prevents logical errors
    3. PERFORMANCE: Using the right type makes programs faster
    4. CLARITY: Types make code easier to understand

    CATEGORIES OF DATA TYPES:
    - VALUE TYPES: Store actual data (int, double, bool, etc.)
    - REFERENCE TYPES: Store memory addresses (string, objects, etc.)
      (We'll focus on value types first as beginners)
*/

Console.WriteLine("--- SECTION 2: WHAT ARE DATA TYPES? ---");
Console.WriteLine("Data types tell C# what kind of information we're storing.");
Console.WriteLine();

// ============================================================================
// SECTION 3: PRIMITIVE (BUILT-IN) DATA TYPES
// ============================================================================

/*
    THE MOST COMMON PRIMITIVE DATA TYPES IN C#:

    1. INT - Integer (whole numbers)
       Range: -2,147,483,648 to 2,147,483,647
       Example: 25, -10, 0, 1000
       Use for: Age, count, quantity, scores

    2. DOUBLE - Decimal numbers (high precision)
       Range: Very large or very small decimal numbers
       Example: 3.14, -25.5, 0.001
       Use for: Height, weight, price, measurements

    3. FLOAT - Decimal numbers (less precision than double)
       Range: Similar to double but less precise
       Example: 3.14f, 25.5f (note the 'f' suffix)
       Use for: Graphics, games, when memory matters

    4. CHAR - Single character
       Range: Any single character from keyboard
       Example: 'A', '5', '!', ' ' (space)
       Use for: Single letters, symbols

    5. BOOL - Boolean (true or false)
       Values: true or false (only these two)
       Example: true, false
       Use for: Yes/No decisions, flags, conditions

    6. STRING - Text/sequence of characters
       Range: Unlimited text
       Example: "Hello", "Gideon", "I love C#", ""
       Use for: Names, messages, addresses, any text
*/

Console.WriteLine("--- SECTION 3: PRIMITIVE DATA TYPES ---");
Console.WriteLine();

// ============================================================================
// SECTION 4 & 5: VARIABLES - DECLARATION & INITIALIZATION
// ============================================================================

/*
    WHAT IS A VARIABLE?
    - A named container that stores a value
    - Like a labeled box where we put data
    - We can retrieve and change the value later

    VARIABLE DECLARATION SYNTAX:
    dataType variableName;
    Example: int age;

    VARIABLE INITIALIZATION:
    variableName = value;
    Example: age = 25;

    COMBINED (Declaration + Initialization):
    dataType variableName = value;
    Example: int age = 25;

    VARIABLE NAMING RULES (IMPORTANT):
    1. Start with a letter or underscore (_)
    2. Can contain letters, numbers, and underscores
    3. Cannot contain spaces
    4. Cannot be a C# keyword (like int, class, etc.)
    5. Case-sensitive (age ≠ Age ≠ AGE)
    6. Use descriptive names (age is better than a)
    7. Convention: Use camelCase (firstName, not FirstName for variables)
*/

//Console.WriteLine("--- SECTION 4 & 5: DECLARING & INITIALIZING VARIABLES ---");
//Console.WriteLine();

//// Example 1: Integer variable
//int studentAge = 20;
//Console.WriteLine("The Student's age is stored in an integer variable:" + studentAge);
//Console.WriteLine($"Student age: {studentAge}");

//// Example 2: Double variable (decimal number)
//double studentHeight = 5.8;
//Console.WriteLine($"Student height: {studentHeight} feet");

//// Example 3: Char variable (single character)
//char grade = 'A';
//Console.WriteLine($"Student grade: {grade}");

//// Example 4: Bool variable (true/false)
//bool isEnrolled = true;
//Console.WriteLine($"Is enrolled: {isEnrolled}");

//// Example 5: String variable (text)
//string studentName = "Gideon";
//Console.WriteLine($"Student name: {studentName}");

//Console.WriteLine();

// ============================================================================
// SECTION 6: PRINTING VARIABLES (THREE METHODS)
// ============================================================================

/*
    ════════════════════════════════════════════════════════════════════════════
    CONCEPT DEEP DIVE: HOW DO WE COMBINE TEXT AND VARIABLES IN OUTPUT?
    ════════════════════════════════════════════════════════════════════════════

    PROBLEM:
    We want to print a message that includes both fixed text AND the value
    stored in a variable. For example, instead of just seeing "20", we want
    to see "The student's age is 20".

    SOLUTION:
    C# gives us THREE ways to combine text and variables. Each has different
    concepts and use cases.

    ════════════════════════════════════════════════════════════════════════════
    METHOD 1: STRING CONCATENATION (The + Operator)
    ════════════════════════════════════════════════════════════════════════════

    CONCEPT:
    "Concatenation" means "joining things together"
    We use the + operator to join strings end-to-end

    HOW IT WORKS STEP-BY-STEP:
    Console.WriteLine("The Student's age is stored in an integer variable:" + studentAge);

    Step 1: "The Student's age is stored in an integer variable:" (this is a STRING)
    Step 2: + (the concatenation operator - joins two things)
    Step 3: studentAge (contains the value 20, which becomes "20" as text)
    Result: "The Student's age is stored in an integer variable:20"

    SYNTAX:
    Console.WriteLine("Text here " + variable + " more text " + variable2);

    WHAT'S HAPPENING UNDER THE HOOD:
    - C# automatically converts the variable (20) to text ("20")
    - This conversion is called "implicit conversion" or "type coercion"
    - The + operator joins strings: "text" + "20" = "text20"

    ADVANTAGES:
    ✓ Works in older versions of C#
    ✓ Conceptually simple once you understand +

    DISADVANTAGES:
    ✗ Gets messy with multiple variables
    ✗ Easy to miss spaces between strings and variables
    ✗ Hard to read and maintain

    EXAMPLE - CONCATENATION METHOD:
    string name = "Ahmed";
    int age = 25;
    Console.WriteLine("The Student's age is stored in an integer variable:" + age);

    Output: The Student's age is stored in an integer variable:25

    PROBLEM WITH THIS METHOD:
    - What if we need: "Ahmed is 25 years old and studies coding"?
    - It becomes: "Name: " + name + " is " + age + " years old and studies coding"
    - Notice all the + signs? Hard to read and error-prone!

    ════════════════════════════════════════════════════════════════════════════
    METHOD 2: STRING INTERPOLATION (The $ prefix with {}) ⭐ RECOMMENDED ⭐
    ════════════════════════════════════════════════════════════════════════════

    CONCEPT:
    "Interpolation" means "inserting values into a template"
    We use $"..." syntax to create a string template with placeholders
    Variables go inside {curly braces}

    HOW IT WORKS STEP-BY-STEP:
    Console.WriteLine($"Student age: {studentAge}");

    Step 1: $ tells C# "This is an interpolated string - look for placeholders"
    Step 2: {studentAge} is a PLACEHOLDER - it will be replaced with the value
    Step 3: C# looks at the variable studentAge, sees it contains 20
    Step 4: Replaces {studentAge} with 20, creating: "Student age: 20"

    SYNTAX:
    Console.WriteLine($"Text here {variable1} more text {variable2}");

    WHAT'S HAPPENING UNDER THE HOOD:
    - The $ prefix tells C# to parse the string for {placeholders}
    - C# evaluates the expression inside {}
    - Replaces {expression} with the result
    - Much more efficient than concatenation

    ADVANTAGES:
    ✓ Clean and easy to read
    ✓ Much easier to maintain
    ✓ More efficient (C# 6.0+)
    ✓ Spaces are preserved naturally
    ✓ Can put expressions inside {}, not just variables
    ✓ This is the modern C# way (recommended by Microsoft)

    DISADVANTAGES:
    ✗ Requires C# 6.0 or newer (but .NET 8 has this!)

    EXAMPLE - STRING INTERPOLATION METHOD:
    string name = "Ahmed";
    int age = 25;
    Console.WriteLine($"Student age: {age}");

    Output: Student age: 25

    POWER OF THIS METHOD:
    Compare concatenation vs interpolation with multiple variables:

    CONCATENATION (messy):
    Console.WriteLine("Name: " + name + " is " + age + " years old and studies coding");

    STRING INTERPOLATION (clean):
    Console.WriteLine($"Name: {name} is {age} years old and studies coding");

    Notice how interpolation is much more readable! The sentence is clear
    and you can see the structure immediately.

    CAN YOU PUT EXPRESSIONS IN {}?
    YES! You can do math and operations inside {}:
    Console.WriteLine($"Next year, I'll be {age + 1} years old");
    Output: Next year, I'll be 26 years old

    ════════════════════════════════════════════════════════════════════════════
    COMPARISON: CONCATENATION vs STRING INTERPOLATION
    ════════════════════════════════════════════════════════════════════════════

    SCENARIO: Display student info

    USING CONCATENATION:
    Console.WriteLine("The Student's age is stored in an integer variable:" + studentAge);

    USING STRING INTERPOLATION:
    Console.WriteLine($"Student age: {studentAge}");

    READABILITY:
    - Concatenation: Must scan through all the + signs
    - Interpolation: Easy to see the text and where values go

    COMPLEXITY WITH MULTIPLE VARIABLES:

    CONCATENATION:
    Console.WriteLine("Student " + name + " age " + age + " grade " + grade + " enrolled " + enrolled);
    (Hard to see the pattern!)

    INTERPOLATION:
    Console.WriteLine($"Student {name} age {age} grade {grade} enrolled {enrolled}");
    (Clear pattern, easy to read!)

    ════════════════════════════════════════════════════════════════════════════
    METHOD 3: COMPOSITE FORMATTING (Less common, but useful sometimes)
    ════════════════════════════════════════════════════════════════════════════

    CONCEPT:
    Uses numbered placeholders {0}, {1}, {2} for each variable
    Variables are passed as separate parameters after the format string

    SYNTAX:
    Console.WriteLine("Text {0} more text {1}", variable1, variable2);

    DISADVANTAGES:
    - Harder to read than interpolation
    - {0} and {1} are not as clear as {variableName}
    - More verbose

    ADVANTAGES:
    - Can be useful for complex formatting scenarios
    - Works in very old C# versions

    ════════════════════════════════════════════════════════════════════════════
    RECOMMENDATION FOR BEGINNERS:
    ════════════════════════════════════════════════════════════════════════════

    🌟 USE STRING INTERPOLATION ($"...{variable}")

    Why?
    1. It's the modern, recommended way in C#
    2. Most readable and maintainable
    3. Most efficient
    4. Used in professional C# code
    5. Easiest to understand

    Only use concatenation if:
    - You're working with very old C# versions (pre-C# 6.0)
    - You're learning about the + operator as a concept

    Never use concatenation in production modern C# code!
*/

//Console.WriteLine("--- SECTION 6: PRINTING VARIABLES ---");
//Console.WriteLine();

//// Method 1: Concatenation (joining with +)
//Console.WriteLine("Method 1 - Concatenation (using + to join strings):");
//Console.WriteLine("The Student's age is stored in an integer variable:" + studentAge);
//Console.WriteLine("Name: " + studentName);
//Console.WriteLine();

//// Method 2: String Interpolation (using $"...{}")
//Console.WriteLine("Method 2 - String Interpolation (RECOMMENDED - Modern C# Way):");
//Console.WriteLine($"Student age: {studentAge}");
//Console.WriteLine($"Name: {studentName}");
//Console.WriteLine($"Height: {studentHeight} feet");
//Console.WriteLine($"Grade: {grade}");
//Console.WriteLine($"Is Enrolled: {isEnrolled}");
//Console.WriteLine();

//// COMPARISON: See how much clearer interpolation is!
//Console.WriteLine("COMPARISON - Same info, two different methods:");
//Console.WriteLine();
//Console.WriteLine("❌ Using Concatenation (hard to read):");
//Console.WriteLine("Student information: " + studentName + " age " + studentAge + " GPA would be calculated");
//Console.WriteLine();
//Console.WriteLine("✅ Using Interpolation (clean and clear):");
//Console.WriteLine($"Student information: {studentName} age {studentAge} GPA would be calculated");
//Console.WriteLine();

//// You can even put expressions inside {}!
//Console.WriteLine("BONUS: Expression inside {}: Calculate next year's age");
//Console.WriteLine($"Next year, {studentName} will be {studentAge + 1} years old");
//Console.WriteLine();

//// Method 3: Composite Formatting (using {0}, {1}, etc.)
//Console.WriteLine("Method 3 - Composite Formatting (Less common, but still works):");
//Console.WriteLine("Name: {0}, Age: {1}", studentName, studentAge);
//Console.WriteLine();

// ============================================================================
// SECTION 7: TYPE INFERENCE WITH 'var'
// ============================================================================

/*
    THE 'var' KEYWORD:
    - Allows C# to automatically figure out the data type
    - Still type-safe (once assigned, type is locked)
    - Syntax: var variableName = value;

    WHEN TO USE 'var':
    - When the type is obvious from context
    - Example: var student = "Ahmed"; (clearly a string)

    WHEN NOT TO USE 'var':
    - When clarity matters (especially for beginners)
    - When the type isn't immediately obvious

    BEGINNER RECOMMENDATION:
    - For now, explicitly write the data type (int, string, etc.)
    - Use 'var' only when you fully understand types
*/

//Console.WriteLine("--- SECTION 7: TYPE INFERENCE WITH 'var' ---");
//Console.WriteLine();

//// Using var (C# infers the type is string)
//var courseTitle = "C# Fundamentals";
//Console.WriteLine($"Course: {courseTitle}");

//// Using var (C# infers the type is int)
//var studentCount = 50;
//Console.WriteLine($"Students in class: {studentCount}");

//Console.WriteLine();

// ============================================================================
// SECTION 8: CONSTANTS
// ============================================================================

/*
    WHAT ARE CONSTANTS?
    - Variables that CANNOT be changed after initialization
    - Value is fixed for the entire program
    - Declared with 'const' keyword

    SYNTAX:
    const dataType CONSTANT_NAME = value;

    NAMING CONVENTION FOR CONSTANTS:
    - Use ALL_CAPS with underscores (e.g., PI, MAX_AGE, CLASS_SIZE)
    - This signals to programmers: "Don't try to change this!"

    WHEN TO USE CONSTANTS:
    - Fixed values that never change (PI, speed of light, etc.)
    - Configuration values (max login attempts, timeout duration)
    - Magic numbers that appear multiple times in code

    ADVANTAGE:
    - Prevents accidental changes
    - Makes code more maintainable
    - Easier to update values globally
*/

//Console.WriteLine("--- SECTION 8: CONSTANTS ---");
//Console.WriteLine();

//const double PI = 3.14159;
//const int MAX_STUDENTS = 100;
//const string COURSE_NAME = "C# Fundamentals";

//Console.WriteLine($"Pi value: {PI}");
//Console.WriteLine($"Max students: {MAX_STUDENTS}");
//Console.WriteLine($"Course name: {COURSE_NAME}");
//Console.WriteLine("(These values cannot be changed—they're constants!)");
//Console.WriteLine();

// This would cause an error if we uncommented it:
// PI = 3.14; // ERROR: Cannot assign to const!

// ============================================================================
// SECTION 9: DEFAULT VALUES OF DATA TYPES
// ============================================================================

/*
    DEFAULT VALUES:
    When variables are declared but NOT initialized, they have default values:

    VALUE TYPES:
    - int, double, float, char: Default is 0 or equivalent
    - bool: Default is false

    REFERENCE TYPES:
    - string: Default is null (no value)
    - objects: Default is null

    IMPORTANT FOR BEGINNERS:
    - In local variables (inside methods), you MUST initialize before use
    - Global variables auto-initialize to default
    - Using uninitialized local variables causes compilation errors
*/

//Console.WriteLine("--- SECTION 9: DEFAULT VALUES ---");
//Console.WriteLine();

//int unitializedInt;  // Not initialized yet
//// Console.WriteLine(unitializedInt); // ERROR in local scope!

//// But if we initialize:
//int initializedInt = 0;
//Console.WriteLine($"Initialized int: {initializedInt}");

//bool unintializedBool = false; // Must initialize in local scope
//Console.WriteLine($"Uninitialized bool treated as: {unintializedBool}");

//string unintializedString = null; // No value assigned
//Console.WriteLine($"Uninitialized string: {unintializedString}");

//Console.WriteLine();

// ============================================================================
// SECTION 10: TYPE CONVERSION (IMPLICIT & EXPLICIT)
// ============================================================================

/*
    WHAT IS TYPE CONVERSION?
    - Converting a value from one data type to another
    - Sometimes automatic, sometimes requires explicit action

    IMPLICIT CONVERSION (Automatic - Safe):
    - Happens automatically when converting to a "larger" type
    - No data loss possible
    - Syntax: No casting needed
    - Example: int → double (25 becomes 25.0)

    EXPLICIT CONVERSION (Manual - Requires Casting):
    - Must be done manually using casting syntax
    - Risk of data loss (e.g., 25.7 → 25)
    - Syntax: (targetType)value
    - Example: (int)25.7 becomes 25

    WHY EACH ONE?
    - Implicit: Safe automatic conversions
    - Explicit: When you know what you're doing and accept the risk
*/

//Console.WriteLine("--- SECTION 10: TYPE CONVERSION ---");
//Console.WriteLine();

//// Implicit Conversion (int to double - safe, automatic)
//int wholeNumber = 10;
//double decimalNumber = wholeNumber;  // Automatic conversion
//Console.WriteLine($"Int {wholeNumber} implicitly converted to double: {decimalNumber}");

//// Explicit Conversion / Casting (double to int - potential data loss)
//double originalDouble = 10.9;
//int castedInt = (int)originalDouble;  // Explicit casting required
//Console.WriteLine($"Double {originalDouble} explicitly cast to int: {castedInt}");
//Console.WriteLine("Note: Decimal part (.9) was lost in the conversion!");

//// String to number (common for user input)
//string numberAsString = "42";
//int numberFromString = int.Parse(numberAsString);
//Console.WriteLine($"String '{numberAsString}' converted to int: {numberFromString}");

//Console.WriteLine();

// ============================================================================
// SECTION 11: COMPLETE PRACTICE TASK
// ============================================================================

/*
    COMPREHENSIVE EXERCISE:
    Create a student profile that demonstrates all concepts learned:
    1. Declare variables of different types
    2. Assign realistic values
    3. Print them in formatted output

    This combines everything into one practical task!
*/

//Console.WriteLine("--- SECTION 11: COMPLETE PRACTICE TASK ---");
//Console.WriteLine("Building a Complete Student Profile:");
//Console.WriteLine();

//// Declare and initialize student information
//string firstName = "Ahmed";
//string lastName = "Hassan";
//int age = 22;
//double gpa = 3.85;
//char letterGrade = 'A';
//bool isFullTime = true;
//int creditHours = 15;
//double tuitionCost = 5500.00;

//// Print formatted output
//Console.WriteLine("╔════════════════════════════════════════╗");
//Console.WriteLine("║        STUDENT PROFILE REPORT          ║");
//Console.WriteLine("╚════════════════════════════════════════╝");
//Console.WriteLine();
//Console.WriteLine($"Name:              {firstName} {lastName}");
//Console.WriteLine($"Age:               {age} years old");
//Console.WriteLine($"GPA:               {gpa}");
//Console.WriteLine($"Letter Grade:      {letterGrade}");
//Console.WriteLine($"Full-Time Student: {isFullTime}");
//Console.WriteLine($"Credit Hours:      {creditHours}");
//Console.WriteLine($"Tuition Cost:      ${tuitionCost:F2}");
//Console.WriteLine();

// ============================================================================
// SECTION 12: COMMON BEGINNER MISTAKES
// ============================================================================

/*
    MISTAKE #1: FORGETTING SEMICOLONS
    Wrong: int age = 25
    Right: int age = 25;
    Consequence: Compilation error

    MISTAKE #2: TYPE MISMATCH
    Wrong: int age = "twenty-five";
    Right: int age = 25; or string age = "twenty-five";
    Consequence: Compilation error

    MISTAKE #3: USING WRONG DATA TYPE
    Wrong: int height = 5.8; (loses decimal part)
    Right: double height = 5.8;
    Consequence: Data loss or compilation error

    MISTAKE #4: NOT INITIALIZING VARIABLES BEFORE USE
    Wrong: int age; Console.WriteLine(age);
    Right: int age = 0; Console.WriteLine(age);
    Consequence: Compilation error in local scope

    MISTAKE #5: CASE SENSITIVITY
    Wrong: int Age = 25; Console.WriteLine(age);
    Right: int age = 25; Console.WriteLine(age);
    Consequence: Error - age and Age are different!

    MISTAKE #6: INVALID VARIABLE NAMES
    Wrong: int 2students; int student-name; int student age;
    Right: int twoStudents; int studentName; int studentAge;
    Consequence: Syntax errors
*/

//Console.WriteLine("--- SECTION 12: COMMON BEGINNER MISTAKES ---");
//Console.WriteLine();
//Console.WriteLine("Common Mistake Examples:");
//Console.WriteLine("✓ CORRECT: int count = 10;");
//Console.WriteLine("✗ MISTAKE: int count = 10 (missing semicolon)");
//Console.WriteLine();
//Console.WriteLine("✓ CORRECT: double salary = 5500.50;");
//Console.WriteLine("✗ MISTAKE: int salary = 5500.50; (wrong type, data loss)");
//Console.WriteLine();
//Console.WriteLine("✓ CORRECT: string name = \"Alice\";");
//Console.WriteLine("✗ MISTAKE: int name = \"Alice\"; (type mismatch)");
//Console.WriteLine();
//Console.WriteLine("✓ CORRECT: int age = 25;");
//Console.WriteLine("✗ MISTAKE: int Age = 25; then using 'age' (case sensitive)");
//Console.WriteLine();

// ============================================================================
// SECTION 13: MINI CHALLENGE FOR STUDENTS
// ============================================================================

/*
    MINI CHALLENGE - PRACTICE TASKS:

    Challenge 1: Create Your Own Profile
    - Store your name, age, favorite color, and whether you like coding
    - Print them using string interpolation

    Challenge 2: Simple Calculation
    - Store two numbers in variables
    - Add them together and display the result

    Challenge 3: Type Conversion
    - Store a decimal number
    - Convert it to integer and compare the original vs converted

    Challenge 4: Constants
    - Define a constant for the course name
    - Define a constant for the year
    - Use them in a sentence

    Challenge 5: Mixed Types
    - Create variables: book title (string), pages (int), price (double), borrowed (bool)
    - Print a complete book description
*/

//Console.WriteLine("--- SECTION 13: MINI CHALLENGES ---");
//Console.WriteLine();
//Console.WriteLine("CHALLENGE 1: Modify the student profile above with your own data!");
//Console.WriteLine("CHALLENGE 2: Create a variable for your favorite food and print it!");
//Console.WriteLine("CHALLENGE 3: Store a decimal number and cast it to integer!");
//Console.WriteLine("CHALLENGE 4: Define constants for your school and year!");
//Console.WriteLine("CHALLENGE 5: Create a book record (title, pages, price, borrowed)!");
//Console.WriteLine();

//// Example Mini Challenge Solution:
//Console.WriteLine("--- MINI CHALLENGE EXAMPLE SOLUTION ---");
//Console.WriteLine();

//// Challenge 1: Student Profile
//string studentFirstName = "Sarah";
//int studentAge1 = 19;
//string favoriteColor = "Blue";
//bool likeCoding = true;

//Console.WriteLine($"Name: {studentFirstName}");
//Console.WriteLine($"Age: {studentAge1}");
//Console.WriteLine($"Favorite Color: {favoriteColor}");
//Console.WriteLine($"Likes Coding: {likeCoding}");
//Console.WriteLine();

//// Challenge 2: Simple Calculation
//int firstNumber = 15;
//int secondNumber = 25;
//int sum = firstNumber + secondNumber;
//Console.WriteLine($"{firstNumber} + {secondNumber} = {sum}");
//Console.WriteLine();

//// Challenge 3: Type Conversion
//double decimalValue = 99.99;
//int intValue = (int)decimalValue;
//Console.WriteLine($"Original decimal: {decimalValue}");
//Console.WriteLine($"Converted to int: {intValue}");
//Console.WriteLine($"Difference: {decimalValue - intValue}");
//Console.WriteLine();

//// Challenge 4: Constants
//const string SCHOOL_NAME = "Kodecamp";
//const int CURRENT_YEAR = 2024;
//Console.WriteLine($"Welcome to {SCHOOL_NAME} in {CURRENT_YEAR}!");
//Console.WriteLine();

//// Challenge 5: Book Record
//string bookTitle = "Clean Code";
//int bookPages = 464;
//double bookPrice = 45.99;
//bool isBookBorrowed = false;
//Console.WriteLine($"Book: {bookTitle}");
//Console.WriteLine($"Pages: {bookPages}");
//Console.WriteLine($"Price: ${bookPrice}");
//Console.WriteLine($"Borrowed: {isBookBorrowed}");
//Console.WriteLine();

// ============================================================================
// LESSON SUMMARY
// ============================================================================

//Console.WriteLine("═══════════════════════════════════════════════════════════");
//Console.WriteLine("                    LESSON SUMMARY");
//Console.WriteLine("═══════════════════════════════════════════════════════════");
//Console.WriteLine();
//Console.WriteLine("KEY TAKEAWAYS:");
//Console.WriteLine("1. Data types specify what kind of data variables hold");
//Console.WriteLine("2. Common types: int, double, float, char, bool, string");
//Console.WriteLine("3. Variables are named containers for storing values");
//Console.WriteLine("4. Use string interpolation $\"...{variable}\" for output");
//Console.WriteLine("5. Constants cannot change after initialization");
//Console.WriteLine("6. Type conversion: implicit (automatic) or explicit (casting)");
//Console.WriteLine("7. Follow naming conventions and initialize variables properly");
//Console.WriteLine();
//Console.WriteLine("NEXT LESSONS:");
//Console.WriteLine("- Operators (+, -, *, /, %, ==, !=, etc.)");
//Console.WriteLine("- Conditional statements (if, else, switch)");
//Console.WriteLine("- Loops (for, while, foreach)");
//Console.WriteLine("- Methods and functions");
//Console.WriteLine("- Arrays and collections");
//Console.WriteLine();
//Console.WriteLine("═══════════════════════════════════════════════════════════");
//Console.WriteLine("           GREAT JOB COMPLETING THIS LESSON! 🎉");
//Console.WriteLine("═══════════════════════════════════════════════════════════");
