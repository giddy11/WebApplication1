// List
//
// When you need an array that is dynamic (it can grow and it can shrink) - List
// When to use List:
// 1. When yoou dont know the number of items in advance
// 2. when you need to add or remove items

// When declaring a List
// 1. List
// 2. <data type>
// 3. the variable name
// 4. values which is in curly brace(new)

//A list of string data type
List<string> names = new List<string>();// []- no items yet
names.Add("Ebuka");
names.Add("Akin");
names.Add("Daniel");
names.Add("Akin");
names.Add("Akin");
names.Add("Akin");
names.Add("Akin");
names.Add("Akin");
names.Add("Caroline");
names.Add("Akin");
names.Add("Akin");

foreach (string name in names)
{
    Console.WriteLine(name);
}

Console.WriteLine("After removing the items:");
names.Remove("Akin");

foreach (string name in names)
{
    Console.WriteLine(name);
}


//A List of int data type
List<int> numbers = new List<int>();
