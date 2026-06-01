namespace ConsoleApp3
{
    public class Animal
    {
        public string Name { get; set; }
        public string Breed { get; set; }
        public string Color { get; set; }

        public void Eat()
        {
            Console.WriteLine($"{Name} is eating.");
        }

        public void Sleep()
        {
            Console.WriteLine($"{Name} is sleeping");
        }

        //virtual and override
    }
}
