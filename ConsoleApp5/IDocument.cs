namespace ConsoleApp5
{
    interface IDocument
    {
        void Read();
        void Print();
    }

    public class PdfDocument : IDocument
    {
        public string Title { get; set; }

        public void Read()
        {
            Console.WriteLine("PDF Read Logic");
        }

        public void Print()
        {
            Console.WriteLine("PDF Print Logic");
        }
    }

    public class WordDocument : IDocument
    {
        public string Title { get; set; }

        public void Print()
        {
            Console.WriteLine("Word Read Logic");
        }

        public void Read()
        {
            Console.WriteLine("Word Print Logic");
        }
    }


}
