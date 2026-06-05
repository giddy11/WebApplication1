namespace ConsoleApp5
{
    public class EmailNotifier : INotify, IDisplay
    {
        //public void SendMessage(string message)
        //{

        //}
        public void SendMessage(string message)
        {
            
        }

        public void ShowStatus()
        {
            
        }
    }

    public class SMSNotifier
    {
    }

    public class InAppNotifier
    {
    }

    interface INotify
    {
        void SendMessage(string message);
    }

    interface IDisplay
    {
        void ShowStatus();
    }
}
