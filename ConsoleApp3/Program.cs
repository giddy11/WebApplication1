// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

//count until a certain condition is met. initial value = 1. value <=15

//int count = 0;

//while (count <= 15)
//{
//    Console.WriteLine("Hello world - " + count++); // ask asignemt.
//    count++;
//}

//Console.WriteLine("The end of the while loop");


// arrays of strings - mango, pawpaw, maize, etc
// arrays of numbers - 1,2,3,4,5,6
//FOREACH

string[] names = {"Ebuka", "Daniel", "Rita"}; //ebuka, daniel, rita
int[] numbers = { 1, 2, 3, 4, 5, 6, 7 };

foreach( string name in names)
{
    Console.WriteLine(name);
}


foreach( int number in numbers)
{
    Console.WriteLine(number);
}