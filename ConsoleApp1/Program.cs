/*
    ============================================================================
    C# FUNDAMENTALS: OPERATORS, EXPRESSIONS & STRING HANDLING
    ============================================================================

    LESSON OVERVIEW:
    This lesson covers operators, expressions, and string manipulation in C#.
    By the end, students will understand how to:
    - Perform calculations and comparisons using operators
    - Build complex expressions
    - Manipulate and work with text data
    - Understand operator precedence

    PREREQUISITE KNOWLEDGE:
    - Data types (int, double, string, bool, etc.)
    - Variables and variable declaration
    - Console.WriteLine() for output
    ============================================================================
*/

//Console.WriteLine("═══════════════════════════════════════════════════════════");
//Console.WriteLine("       C# OPERATORS, EXPRESSIONS & STRING HANDLING");
//Console.WriteLine("═══════════════════════════════════════════════════════════");
//Console.WriteLine();

// ============================================================================
// SECTION 1: WHAT ARE OPERATORS?
// ============================================================================

/*
    DEFINITION:
    Operators are symbols that tell C# to perform actions on variables and values.
    They are the verbs of programming—they DO SOMETHING with data.

    ANALOGY:
    Think of operators like actions in real life:
    - + means "add these numbers together"
    - - means "subtract one from the other"
    - > means "is this greater than that?"
    - = means "store this value in that variable"

    CATEGORIES OF OPERATORS:
    1. Arithmetic Operators (+, -, *, /, %)
    2. Assignment Operators (=, +=, -=, etc.)
    3. Comparison Operators (==, !=, <, >, <=, >=)
    4. Logical Operators (&&, ||, !)
    5. String Operators (+, for concatenation)

    In this lesson, we'll explore each category with examples.
*/

//Console.WriteLine("--- SECTION 1: WHAT ARE OPERATORS? ---");
//Console.WriteLine();

// ============================================================================
// SECTION 2: ARITHMETIC OPERATORS (Mathematical Operations)
// ============================================================================

/*
    ARITHMETIC OPERATORS:
    These operators perform mathematical calculations.

    OPERATOR | NAME           | EXAMPLE    | RESULT
    ═══════════════════════════════════════════════════════════════
    +        | Addition       | 10 + 5     | 15
    -        | Subtraction    | 10 - 5     | 5
    *        | Multiplication | 10 * 5     | 50
    /        | Division       | 10 / 5     | 2
    %        | Modulus        | 10 % 3     | 1 (remainder)

    IMPORTANT CONCEPTS:

    1. ADDITION (+)
       - Adds two numbers
       - Also used for concatenating strings (covered later)

    2. SUBTRACTION (-)
       - Subtracts second number from first
       - Can result in negative numbers

    3. MULTIPLICATION (*)
       - Multiplies two numbers
       - Can be used with decimals (double, float)

    4. DIVISION (/)
       - Divides first number by second
       - Integer division: 10 / 3 = 3 (no remainder shown)
       - Decimal division: 10.0 / 3 = 3.333...

    5. MODULUS (%) - THE REMAINDER OPERATOR
       - Returns the REMAINDER after division
       - Used to find: even/odd numbers, cycles, patterns
       - 10 % 3 = 1 (10 divided by 3 is 3 with remainder 1)
       - 10 % 2 = 0 (10 is even—no remainder)
       - 11 % 2 = 1 (11 is odd—remainder 1)

    OPERATOR PRECEDENCE (Order of operations):
    C# follows PEMDAS/BODMAS rules:
    1. * / % (executed first, left to right)
    2. + - (executed second, left to right)

    Example: 10 + 5 * 2
    - First: 5 * 2 = 10
    - Then: 10 + 10 = 20 (NOT 30!)

    Use parentheses to control order:
    (10 + 5) * 2 = 30
*/

//Console.WriteLine("--- SECTION 2: ARITHMETIC OPERATORS ---");
//Console.WriteLine();

//int num1 = 10;
//int num2 = 3;

//Console.WriteLine("Basic Arithmetic Operations:");
//Console.WriteLine($"{num1} + {num2} = {num1 + num2}");           // 13
//Console.WriteLine($"{num1} - {num2} = {num1 - num2}");           // 7
//Console.WriteLine($"{num1} * {num2} = {num1 * num2}");           // 30
//Console.WriteLine($"{num1} / {num2} = {num1 / num2}");           // 3 (integer division)
//Console.WriteLine($"{num1} % {num2} = {num1 % num2}");           // 1 (remainder)
//Console.WriteLine();

//// Decimal division (with double)
//double decimalNum1 = 10.0;
//double decimalNum2 = 3.0;
//Console.WriteLine("Decimal Division (with double):");
//Console.WriteLine($"{decimalNum1} / {decimalNum2} = {decimalNum1 / decimalNum2}");
//Console.WriteLine();

//// Operator precedence examples
//Console.WriteLine("Operator Precedence (PEMDAS/BODMAS):");
//int result1 = 10 + 5 * 2;
//Console.WriteLine($"10 + 5 * 2 = {result1} (multiply first: 5*2=10, then 10+10=20)");

//int result2 = (10 + 5) * 2;
//Console.WriteLine($"(10 + 5) * 2 = {result2} (parentheses first: 10+5=15, then 15*2=30)");
//Console.WriteLine();

//// Practical example: Modulus for even/odd
//int testNum = 7;
//int remainder = testNum % 2;
//Console.WriteLine($"Is {testNum} even or odd?");
//Console.WriteLine($"{testNum} % 2 = {remainder}");
//Console.WriteLine($"Result: {testNum} is {(remainder == 0 ? "EVEN" : "ODD")}");
//Console.WriteLine();

// ============================================================================
// SECTION 3: ASSIGNMENT OPERATORS
// ============================================================================

//int a = 5;
//int b = a + 5;

//int c = b + 5;

//b += 5; // b = b + 5


/*
    ASSIGNMENT OPERATORS:
    These operators assign (store) values in variables.

    OPERATOR | MEANING              | EXAMPLE | EQUIVALENT TO
    ═════════════════════════════════════════════════════════════════
    =        | Assign               | x = 5   | x = 5
    +=       | Add and assign       | x += 3  | x = x + 3
    -=       | Subtract and assign  | x -= 2  | x = x - 2
    *=       | Multiply and assign  | x *= 4  | x = x * 4
    /=       | Divide and assign    | x /= 2  | x = x / 2
    %=       | Modulus and assign   | x %= 3  | x = x % 3

    THE SIMPLE ASSIGNMENT OPERATOR (=):
    - Assigns the value on the right to the variable on the left
    - NOT the same as "equals" in math
    - In programming: x = 5 means "store 5 in x"
    - In math: x = 5 means "x has the value 5"

    COMPOUND ASSIGNMENT OPERATORS (+=, -=, etc.):
    - Shorthand for performing an operation AND storing the result
    - x += 3 is the same as x = x + 3
    - More concise and commonly used in professional code

    WHY USE COMPOUND OPERATORS?
    - Cleaner code
    - Less typing
    - Shows intent clearly: "add 3 to x"
    - Commonly used in loops (covered later)
*/

//Console.WriteLine("--- SECTION 3: ASSIGNMENT OPERATORS ---");
//Console.WriteLine();

//int score = 10;
//Console.WriteLine($"Initial score: {score}");

//score += 5;  // score = score + 5
//Console.WriteLine($"After += 5: {score}");

//score -= 2;  // score = score - 2
//Console.WriteLine($"After -= 2: {score}");

//score *= 2;  // score = score * 2
//Console.WriteLine($"After *= 2: {score}");

//score /= 3;  // score = score / 3
//Console.WriteLine($"After /= 3: {score}");

//score %= 5;  // score = score % 5
//Console.WriteLine($"After %= 5: {score}");
//Console.WriteLine();

// ============================================================================
// SECTION 4: COMPARISON OPERATORS
// ============================================================================

/*
    COMPARISON OPERATORS:
    These operators compare two values and return TRUE or FALSE (bool).

    OPERATOR | MEANING                | EXAMPLE    | RESULT
    ═════════════════════════════════════════════════════════════════════
    ==       | Equal to               | 5 == 5     | true
    !=       | Not equal to           | 5 != 3     | true
    <        | Less than              | 3 < 5      | true
    >        | Greater than           | 5 > 3      | true
    <=       | Less than or equal     | 5 <= 5     | true
    >=       | Greater than or equal  | 5 >= 3     | true

    IMPORTANT DISTINCTIONS:

    = (ASSIGNMENT) vs == (COMPARISON)
    - = assigns a value: x = 5 (store 5 in x)
    - == compares values: x == 5 (is x equal to 5?)
    - COMMON BEGINNER MISTAKE: Using = when you mean ==

    RESULT:
    - Comparison operators ALWAYS return a bool (true or false)
    - You can store the result in a bool variable
    - You can use the result directly in Console.WriteLine()

    USE CASES:
    - Making decisions (if statements, covered later)
    - Validating data
    - Filtering information
    - Comparing numbers, strings, and other data
*/

//Console.WriteLine("--- SECTION 4: COMPARISON OPERATORS ---");
//Console.WriteLine();

//int age = 20;
//int requiredAge = 18;

//Console.WriteLine("Comparison Examples:");
//Console.WriteLine($"age = {age}, requiredAge = {requiredAge}");
////Console.WriteLine();

//Console.WriteLine($"{age} == {requiredAge} → {age == requiredAge}");      // false
//Console.WriteLine($"{age} != {requiredAge} → {age != requiredAge}");      // true
//Console.WriteLine($"{age} < {requiredAge} → {age < requiredAge}");        // false
//Console.WriteLine($"{age} > {requiredAge} → {age > requiredAge}");        // true
//Console.WriteLine($"{age} <= {requiredAge} → {age <= requiredAge}");      // false
//Console.WriteLine($"{age} >= {requiredAge} → {age >= requiredAge}");      // true
//Console.WriteLine();

//// Storing comparison results in a bool variable
//bool isOldEnough = age >= requiredAge;
//Console.WriteLine($"Is age {age} >= required age {requiredAge}? {isOldEnough}");
//Console.WriteLine();

// ============================================================================
// SECTION 5: LOGICAL OPERATORS
// ============================================================================

/*
    LOGICAL OPERATORS:
    These operators combine boolean values (true/false) to create more complex conditions.

    OPERATOR | NAME        | MEANING                                  | EXAMPLE
    ═════════════════════════════════════════════════════════════════════════════
    &&       | AND         | BOTH conditions must be true             | true && false = true
    ||       | OR          | AT LEAST ONE condition must be true      | false || false = true
    !        | NOT         | Reverses the boolean value               | !true = false


    THE && (AND) OPERATOR:
    - Returns true only if BOTH conditions are true
    - If either condition is false, result is false

    Truth Table for AND (&&):
    ┌─────────┬─────────┬──────────┐
    │ Left    │ Right   │ Result   │
    ├─────────┼─────────┼──────────┤
    │ true    │ true    │ true     │
    │ true    │ false   │ false    │
    │ false   │ true    │ false    │
    │ false   │ false   │ false    │
    └─────────┴─────────┴──────────┘

    THE || (OR) OPERATOR:
    - Returns true if AT LEAST ONE condition is true
    - Only returns false if both conditions are false

    Truth Table for OR (||):
    ┌─────────┬─────────┬──────────┐
    │ Left    │ Right   │ Result   │
    ├─────────┼─────────┼──────────┤
    │ true    │ true    │ true     │
    │ true    │ false   │ true     │
    │ false   │ true    │ true     │
    │ false   │ false   │ false    │
    └─────────┴─────────┴──────────┘

    THE ! (NOT) OPERATOR:
    - Reverses the boolean value
    - !true becomes false
    - !false becomes true
    - Used to negate conditions

    PRACTICAL EXAMPLES:

    Example 1: AND (&&)
    "Is the user age >= 18 AND is the user a student?"
    Both must be true to proceed.

    Example 2: OR (||)
    "Does the user have a credit card OR do they have cash?"
    At least one must be true to make a purchase.

    Example 3: NOT (!)
    "Is the user NOT an admin?"
    Restricts access if user is not an admin.
*/

//int a = 5;
//int b = 10;
//int c = 15;
//int d = 10;

//int result = a + 10;

//bool answer = 


//bool result = 

//Console.WriteLine();



//Console.WriteLine("--- SECTION 5: LOGICAL OPERATORS ---");
//Console.WriteLine();

//bool hasLicense = true;
//bool hasInsurance = true;
//bool isStudent = false;

//Console.WriteLine("Logical Operator Examples:");
//Console.WriteLine($"hasLicense: {hasLicense}");
//Console.WriteLine($"hasInsurance: {hasInsurance}");
//Console.WriteLine($"isStudent: {isStudent}");
//Console.WriteLine();

//// AND (&&) - Both must be true
//Console.WriteLine("AND (&&) Operator - Both conditions must be true:");
//bool canDrive = hasLicense || !hasInsurance;
//Console.WriteLine($"hasLicense && hasInsurance = {canDrive}");
//Console.WriteLine($"To drive legally, you need BOTH license AND insurance");
//Console.WriteLine();

//// OR (||) - At least one must be true
//Console.WriteLine("OR (||) Operator - At least one condition must be true:");
//bool hasDiscount = isStudent || hasLicense;
//Console.WriteLine($"isStudent || hasLicense = {hasDiscount}");
//Console.WriteLine($"You get a discount if you're a STUDENT OR you have a LICENSE");
//Console.WriteLine();

//// NOT (!) - Reverses the boolean
//Console.WriteLine("NOT (!) Operator - Reverses the boolean:");
//bool isNotStudent = !isStudent;
//Console.WriteLine($"!isStudent = {isNotStudent}");
//Console.WriteLine();

//// Complex condition
//Console.WriteLine("Complex Condition (combining operators):");

//bool canRent = !(age >= 18) && (hasLicense || hasInsurance);
//Console.WriteLine($"Can rent a car if: age >= 18 AND (hasLicense OR hasInsurance)");
//Console.WriteLine($"Result: {canRent}");
//Console.WriteLine();

// ============================================================================
// SECTION 6: WHAT ARE EXPRESSIONS?
// ============================================================================

/*
    DEFINITION:
    An expression is a combination of operators, variables, and values that
    evaluates to a single result.

    COMPONENTS OF AN EXPRESSION:
    - Operands: Values or variables (e.g., 10, x, 5)
    - Operators: Symbols that perform actions (+, -, *, ==, &&, etc.)
    - Result: The final value after evaluation

    TYPES OF EXPRESSIONS:

    1. ARITHMETIC EXPRESSIONS:
       - Result is a number
       - Example: 10 + 5 * 2 evaluates to 20
       - Example: (x - 3) * 2 evaluates to a number

    2. BOOLEAN EXPRESSIONS:
       - Result is true or false
       - Example: x > 5 evaluates to true or false
       - Example: (age >= 18) && (hasLicense) evaluates to true or false

    3. STRING EXPRESSIONS:
       - Result is text
       - Example: "Hello " + name evaluates to "Hello Ahmed"

    EXPRESSION EVALUATION:
    - C# reads expressions left to right (mostly)
    - Follows operator precedence (PEMDAS/BODMAS)
    - Evaluates to ONE final result

    STORING EXPRESSION RESULTS:
    - You can store the result of any expression in a variable
    - The variable must be compatible with the result type
    - Example: int result = 10 + 5;
    - Example: bool isValid = (age >= 18);

    USING EXPRESSIONS DIRECTLY:
    - You can use expressions directly without storing them
    - Example: Console.WriteLine(10 + 5);
    - Example: if (x > 5) { ... }
*/


//Console.WriteLine("--- SECTION 6: WHAT ARE EXPRESSIONS? ---");
//Console.WriteLine();

//Console.WriteLine("Arithmetic Expressions (result is a number):");
//int expr1 = 10 + 5;
//int expr2 = 10 * 2 + 5;
//int expr3 = (10 + 5) * 2;
//Console.WriteLine($"10 + 5 = {expr1}");
//Console.WriteLine($"10 * 2 + 5 = {expr2}");
//Console.WriteLine($"(10 + 5) * 2 = {expr3}");
//Console.WriteLine();

//Console.WriteLine("Boolean Expressions (result is true or false):");
//int testAge = 15;
//bool isAdult = testAge >= 18; //
//bool isPaid = true;
//bool canVote = isAdult && isPaid; //
//Console.WriteLine($"testAge >= 18 = {isAdult}");
//Console.WriteLine($"isAdult && isPaid = {canVote}");
//Console.WriteLine();

//Console.WriteLine("Expressions used directly in Console.WriteLine:");
//Console.WriteLine($"Result of 100 / 4 + 10: {100 / 4 + 10}");
//Console.WriteLine($"Is 50 > 30? {50 > 30}");
//Console.WriteLine();

// ============================================================================
// SECTION 7: STRING HANDLING & CONCATENATION
// ============================================================================


/*
    STRING FUNDAMENTALS:
    - Strings are sequences of characters (text)
    - Enclosed in double quotes: "hello", "C# Programming"
    - Can contain spaces, numbers, and special characters

    STRING CONCATENATION:
    Combining multiple strings into one.

    METHOD 1: THE + OPERATOR (CONCATENATION)
    - Joins strings end-to-end
    - Also converts non-strings to strings automatically
    - Syntax: string1 + string2 + string3

    Example:
    string firstName = "Ahmed";
    string lastName = "Hassan";
    string fullName = firstName + " " + lastName;
    Result: "Ahmed Hassan"

    Note the space: " " is important for proper spacing!

    METHOD 2: STRING INTERPOLATION (RECOMMENDED)
    - Uses $"...{variable}" syntax
    - More readable than concatenation
    - Can include expressions inside {}

    Example:
    Console.WriteLine($"Hello, {firstName} {lastName}!");
    Result: "Hello, Ahmed Hassan!"

    IMPORTANT STRING METHODS:
    (Methods are functions that belong to objects - we'll cover this more later)

    1. .Length - Returns the number of characters in a string
       "Hello".Length = 5
       "".Length = 0

    2. .ToUpper() - Converts to UPPERCASE
       "hello".ToUpper() = "HELLO"

    3. .ToLower() - Converts to lowercase
       "HELLO".ToLower() = "hello"

    4. .Substring(start, length) - Extracts part of a string
       "Hello".Substring(1, 3) = "ell"

    5. .Contains(text) - Checks if string contains text
       "Hello World".Contains("World") = true

    6. .Replace(old, new) - Replaces text
       "Hello World".Replace("World", "C#") = "Hello C#"

    7. .Trim() - Removes spaces from start/end
       "  Hello  ".Trim() = "Hello"

    ESCAPE SEQUENCES (Special characters in strings):
    \" - Double quote
    \\ - Backslash
    \n - Newline
    \t - Tab

    Example:
    Console.WriteLine("He said \"Hello!\"");
    Output: He said "Hello!"
*/

// My name is "Bakare". Am a Nigerian \ okay.
//Console.WriteLine("My name is \"Bakare\". Am a Nigerian \\ okay.\n\n");
//Console.WriteLine("Hello world\n");
//Console.WriteLine("Hello world");
//Console.WriteLine("Hello world");
//Console.WriteLine("Hello world");


//Console.WriteLine("--- SECTION 7: STRING HANDLING & CONCATENATION ---");
//Console.WriteLine();

//string firstName = "Gideon";
//string lastName = "Adeyemi";

//Console.WriteLine("String Concatenation (using +):");
//string fullName = firstName + " " + lastName;
//Console.WriteLine($"firstName: {firstName}");
//Console.WriteLine($"lastName: {lastName}");
//Console.WriteLine($"fullName (concatenated): {fullName}");
//Console.WriteLine();

//Console.WriteLine("String Interpolation (using $\"{variable}\"):");
//string greeting = $"Welcome, {firstName}!";
//Console.WriteLine(greeting);
//Console.WriteLine();

//Console.WriteLine("Combining text and numbers:");
//int studentID = 12345;
//double gpa = 3.85;
//Console.WriteLine($"Student {firstName} (ID: {studentID}) has GPA: {gpa}");
//Console.WriteLine();

//// String methods
//Console.WriteLine("String Methods:");
//string text = "Programming";

//Console.WriteLine($"Original string: \"{text}\"");
//Console.WriteLine($"Length: {text.Length}");
//Console.WriteLine($"Uppercase: {text.ToUpper()}");
//Console.WriteLine($"Lowercase: {text.ToLower()}");
//Console.WriteLine($"Contains 'gram': {text.Contains("gram")}");
//Console.WriteLine($"Replace 'Prog' with 'Game': {text.Replace("Prog", "Game")}");
//Console.WriteLine();

//// Escape sequences
//Console.WriteLine("Escape Sequences:");
//Console.WriteLine("This is a line with a \"quote\" inside");
//Console.WriteLine("Line 1\nLine 2\nLine 3");  // \n = newline
//Console.WriteLine("Column1\tColumn2\tColumn3"); // \t = tab
//Console.WriteLine();

//// String comparison
//Console.WriteLine("String Comparison:");
//string word1 = "hello";
//string word2 = "hello";
//string word3 = "Hello".ToLower();

//Console.WriteLine($"word1: \"{word1}\"");
//Console.WriteLine($"word2: \"{word2}\"");
//Console.WriteLine($"word3: \"{word3}\"");
//Console.WriteLine($"word1 == word2: {word1 == word2}");  // true
//Console.WriteLine($"word1 == word3: {word1 == word3}");  // false (case-sensitive!)
//Console.WriteLine();

// ============================================================================
// SECTION 8: PRACTICAL EXAMPLES - COMBINING EVERYTHING
// ============================================================================

/*
    REAL-WORLD SCENARIOS:
    These examples combine operators, expressions, and strings to solve
    practical problems that programmers face every day.
*/

//Console.WriteLine("--- SECTION 8: PRACTICAL EXAMPLES ---");
//Console.WriteLine();

//// Example 1: Calculate age and eligibility
//Console.WriteLine("Example 1: Age Eligibility Checker");
//string personName = "Alice";
//int birthYear = 2000;
//int currentYear = 2024;

//int age = currentYear - birthYear;
//bool canVote = age >= 18;
//bool canDrink = age >= 21;

//Console.WriteLine($"Name: {personName}");
//Console.WriteLine($"Age: {age}");
//Console.WriteLine($"Can vote (18+): {canVote}");
//Console.WriteLine($"Can drink (21+): {canDrink}");
//Console.WriteLine();

//// Example 2: Grade calculation and status
//Console.WriteLine("Example 2: Student Grade Calculator");
//int math = 85;
//int english = 92;
//int science = 78;

//int totalScore = math + english + science;
//double averageScore = totalScore / 3.0;  // Note: 3.0 for decimal result
//bool passed = averageScore >= 60;

//Console.WriteLine($"Math: {math}, English: {english}, Science: {science}");
//Console.WriteLine($"Total: {totalScore}, Average: {averageScore:F2}");
//Console.WriteLine($"Passed: {passed}");
//Console.WriteLine();

//// Example 3: Shopping discount calculator
//Console.WriteLine("Example 3: Shopping Discount Calculator");
//double originalPrice = 100;
//int discountPercent = 15;
//bool isMember = true;

//double discount = (originalPrice * discountPercent) / 100;
//double memberBonus = isMember ? originalPrice * 0.05 : 0;  // ternary operator (bonus)
//double finalPrice = originalPrice - discount - memberBonus;

//Console.WriteLine($"Original Price: ${originalPrice}");
//Console.WriteLine($"Discount ({discountPercent}%): ${discount}");
//Console.WriteLine($"Member Bonus: ${memberBonus}");
//Console.WriteLine($"Final Price: ${finalPrice:F2}");
//Console.WriteLine();

//// Example 4: String manipulation for user input processing
//Console.WriteLine("Example 4: String Processing");
//string userInput = "  CSharp Programming  ";

//string cleaned = userInput.Trim();
//string uppercase = cleaned.ToUpper();
//bool hasSpaces = cleaned.Contains(" ");

//Console.WriteLine($"Raw input: \"{userInput}\"");
//Console.WriteLine($"After Trim: \"{cleaned}\"");
//Console.WriteLine($"Uppercase: \"{uppercase}\"");
//Console.WriteLine($"Contains spaces: {hasSpaces}");
//Console.WriteLine();

// ============================================================================
// SECTION 9: COMMON MISTAKES & BEST PRACTICES
// ============================================================================

/*
    COMMON MISTAKE #1: Using = instead of ==
    Wrong:  if (age = 18) { }   // ASSIGNMENT, not comparison!
    Right:  if (age == 18) { }  // COMPARISON

    COMMON MISTAKE #2: Forgetting operator precedence
    Wrong:  int result = 10 + 5 * 2;  // Programmer expected 30
    Right:  int result = (10 + 5) * 2;  // Clear intent with parentheses

    COMMON MISTAKE #3: Integer division losing decimals
    Wrong:  double result = 10 / 3;     // Result: 3 (not 3.333...)
    Right:  double result = 10.0 / 3;   // Result: 3.333...

    COMMON MISTAKE #4: Concatenating without spaces
    Wrong:  string name = "John"+"Doe";     // "JohnDoe" (no space!)
    Right:  string name = "John" + " " + "Doe";  // "John Doe"

    COMMON MISTAKE #5: Case sensitivity in string comparison
    Wrong:  "hello" == "Hello"  // false! Strings are case-sensitive
    Right:  "hello".ToLower() == "Hello".ToLower()  // true

    BEST PRACTICES:

    1. Use parentheses for clarity, even if not required
       Good: (10 + 5) * 2 = 30 (clear intent)
       Instead of: 10 + 5 * 2 = 20 (requires knowing precedence)

    2. Use meaningful variable names
       Good: int totalScore = math + english;
       Bad: int x = a + b;

    3. Use string interpolation instead of concatenation
       Good: Console.WriteLine($"Score: {score}");
       Bad: Console.WriteLine("Score: " + score);

    4. Be consistent with spacing and formatting
       Makes code easier to read

    5. Add comments for complex expressions
       Helps other programmers (and future you!) understand the logic

    6. Use .ToLower() or .ToUpper() for case-insensitive comparisons
       When comparing user input or data
*/

//Console.WriteLine("--- SECTION 9: COMMON MISTAKES ---");
//Console.WriteLine();
//Console.WriteLine("❌ MISTAKE: Integer division loses decimals");
//int intDiv = 10 / 3;
//Console.WriteLine($"10 / 3 = {intDiv}  (wrong: no decimals)");

//Console.WriteLine();
//Console.WriteLine("✅ CORRECT: Use decimal for precise division");
//double decimalDiv = 10.0 / 3.0;
//Console.WriteLine($"10.0 / 3.0 = {decimalDiv:F3}  (correct: shows decimals)");
//Console.WriteLine();

// ============================================================================
// SECTION 10: MINI CHALLENGES
// ============================================================================

/*
    CHALLENGE 1: Temperature Converter
    - Convert Celsius to Fahrenheit: F = (C * 9/5) + 32
    - Display the result with string interpolation

    CHALLENGE 2: Simple Calculator
    - Take two numbers and perform all operations: +, -, *, /
    - Display results for each operation

    CHALLENGE 3: Age Verification
    - Check if person is old enough to vote (18+) AND has ID
    - Display eligibility message

    CHALLENGE 4: String Manipulation
    - Take a string, find its length, convert to uppercase, check for vowels

    CHALLENGE 5: Discount Calculator
    - Calculate final price after discount
    - Check if customer qualifies for extra member discount
*/

//Console.WriteLine("--- SECTION 10: MINI CHALLENGES (WITH SOLUTIONS) ---");
//Console.WriteLine();

//// Challenge 1: Temperature Converter
//Console.WriteLine("Challenge 1: Temperature Converter");
//double celsius = 25;
//double fahrenheit = (celsius * 9 / 5) + 32;
//Console.WriteLine($"{celsius}°C = {fahrenheit}°F");
//Console.WriteLine();

//// Challenge 2: Simple Calculator
//Console.WriteLine("Challenge 2: Simple Calculator");
//int num_a = 20;
//int num_b = 5;
//Console.WriteLine($"Operations with {num_a} and {num_b}:");
//Console.WriteLine($"Addition: {num_a} + {num_b} = {num_a + num_b}");
//Console.WriteLine($"Subtraction: {num_a} - {num_b} = {num_a - num_b}");
//Console.WriteLine($"Multiplication: {num_a} * {num_b} = {num_a * num_b}");
//Console.WriteLine($"Division: {num_a} / {num_b} = {num_a / num_b}");
//Console.WriteLine();

//// Challenge 3: Age Verification
//Console.WriteLine("Challenge 3: Age Verification");
//string personName_3 = "Bob";
//int personAge = 20;
//bool hasID = true;
//bool canVote_3 = personAge >= 18 && hasID;
//Console.WriteLine($"{personName_3} is {personAge} and has ID: {hasID}");
//Console.WriteLine($"Can vote: {canVote_3}");
//Console.WriteLine();

//// Challenge 4: String Manipulation
//Console.WriteLine("Challenge 4: String Manipulation");
//string challenge_str = "Programming";
//int strLength = challenge_str.Length;
//string strUpper = challenge_str.ToUpper();
//bool hasA = challenge_str.Contains("a");
//bool hasO = challenge_str.Contains("o");
//Console.WriteLine($"String: \"{challenge_str}\"");
//Console.WriteLine($"Length: {strLength}");
//Console.WriteLine($"Uppercase: {strUpper}");
//Console.WriteLine($"Contains 'a': {hasA}");
//Console.WriteLine($"Contains 'o': {hasO}");
//Console.WriteLine();

//// Challenge 5: Discount Calculator
//Console.WriteLine("Challenge 5: Discount Calculator");
//double price = 100;
//int discount_percent = 20;
//bool isMember_5 = true;

//double discountAmount = price * (discount_percent / 100.0);
//double memberDiscount = isMember_5 ? price * 0.1 : 0;
//double final_price = price - discountAmount - memberDiscount;

//Console.WriteLine($"Original: ${price}");
//Console.WriteLine($"Discount ({discount_percent}%): ${discountAmount}");
//Console.WriteLine($"Member bonus (10%): ${memberDiscount}");
//Console.WriteLine($"Final price: ${final_price}");
//Console.WriteLine();

// ============================================================================
// LESSON SUMMARY
// ============================================================================

//Console.WriteLine("═══════════════════════════════════════════════════════════");
//Console.WriteLine("                    LESSON SUMMARY");
//Console.WriteLine("═══════════════════════════════════════════════════════════");
//Console.WriteLine();
//Console.WriteLine("KEY TAKEAWAYS:");
//Console.WriteLine();
//Console.WriteLine("1. ARITHMETIC OPERATORS (+, -, *, /, %):");
//Console.WriteLine("   - Perform mathematical calculations");
//Console.WriteLine("   - Follow PEMDAS/BODMAS precedence");
//Console.WriteLine("   - % returns remainder (useful for even/odd)");
//Console.WriteLine();
//Console.WriteLine("2. ASSIGNMENT OPERATORS (=, +=, -=, etc.):");
//Console.WriteLine("   - Store values in variables");
//Console.WriteLine("   - Compound operators are shorthand (x += 5 means x = x + 5)");
//Console.WriteLine();
//Console.WriteLine("3. COMPARISON OPERATORS (==, !=, <, >, <=, >=):");
//Console.WriteLine("   - Compare values");
//Console.WriteLine("   - Always return true or false");
//Console.WriteLine("   - DO NOT confuse = with ==");
//Console.WriteLine();
//Console.WriteLine("4. LOGICAL OPERATORS (&&, ||, !):");
//Console.WriteLine("   - Combine boolean conditions");
//Console.WriteLine("   - && means both must be true");
//Console.WriteLine("   - || means at least one must be true");
//Console.WriteLine("   - ! reverses the boolean value");
//Console.WriteLine();
//Console.WriteLine("5. EXPRESSIONS:");
//Console.WriteLine("   - Combinations of operators and values");
//Console.WriteLine("   - Evaluate to a single result");
//Console.WriteLine("   - Can be stored in variables or used directly");
//Console.WriteLine();
//Console.WriteLine("6. STRING HANDLING:");
//Console.WriteLine("   - Use + for concatenation or $\"...{variable}\" for interpolation");
//Console.WriteLine("   - String methods: Length, ToUpper(), ToLower(), Contains(), Replace()");
//Console.WriteLine("   - Strings are case-sensitive in comparisons");
//Console.WriteLine();
//Console.WriteLine("NEXT LESSONS:");
//Console.WriteLine("- Conditional statements (if, else, switch)");
//Console.WriteLine("- Loops (for, while, foreach)");
//Console.WriteLine("- Methods and functions");
//Console.WriteLine("- Arrays and collections");
//Console.WriteLine("- Object-oriented programming");
//Console.WriteLine();
//Console.WriteLine("═══════════════════════════════════════════════════════════");
//Console.WriteLine("         EXCELLENT WORK! YOU'VE MASTERED OPERATORS! 🎉");
//Console.WriteLine("═══════════════════════════════════════════════════════════");
