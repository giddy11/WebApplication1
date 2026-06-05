namespace ConsoleApp4
{
    public class Staff
    {
        public string FullName { get; set; }

        public virtual void DoWork()
        {
            Console.WriteLine("Staff is doing work.");
        }
    }
}
