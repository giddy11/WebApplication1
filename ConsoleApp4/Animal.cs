namespace ConsoleApp4
{
    //public abstract class Animal
    //{
    //    public string Name { get; set; }
    //    public Animal(string name)
    //    {
    //        Name = name;
    //    }

    //    public abstract void MakeSound();
    //}

    //public class Cat : Animal
    //{
    //    public Cat(string name) : base(name) 
    //    {
            
    //    }
    //    public override void MakeSound()
    //    {
    //        Console.WriteLine("Meowwwww");
    //    }
    //}

    //public class Car
    //{
    //    public string Name { get; set; }
    //    public Car(string name)
    //    {
    //        Name = name;
    //    }
    //}

    //public class Book
    //{
    //    public string Name { get; set; }
    //    public Book(string name)
    //    {
    //        Name = name;
    //    }
    //}

    //public class Product
    //{
    //    public string Name { get; set; }
    //    public Product(string name)
    //    {
    //        Name = name;
    //    }
    //}

    //public class Shape
    //{
    //    public string Name { get; set; }
    //    public Shape(string name)
    //    {
    //        Name = name;
    //    }
    //}

    //public class Vehicle
    //{
    //    public string Name { get; set; }
    //    public Vehicle(string name)
    //    {
    //        Name = name;
    //    }
    //}

    public abstract class Payment
    {
        public abstract void ProcessPayment(double amount);
    }

    public class CardPayment : Payment
    {
        public override void ProcessPayment(double amount)
        {
            Console.WriteLine();
        }
    }

    public class BankTransfer
    {

    }

    public class CashPayment
    {

    }
}
