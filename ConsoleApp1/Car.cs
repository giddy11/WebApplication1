namespace ConsoleApp1
{
    public class Car
    {
        //This  will have brand, color, speed
        //data
        public string Brand { get; set; }
        public string Color { get; set; }
        public int Speed { get; set; }


        //behaviour
        public void Accelerate()
        {
            Speed += 10;
        }


        //contrutors
    }
}
