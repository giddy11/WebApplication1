namespace ConsoleApp1
{
    public class BankAccount
    {
        public string AccountNumber { get; set; }
        public decimal Balance {  get; set; }

        public void Deposit(string accountNumber, decimal amount)
        {
            if (accountNumber != AccountNumber)
            {
                Console.WriteLine("This account number doesnt exist");
            }
            else
            {
                Balance += amount;
                Console.WriteLine($"You have successfully deposited and your current balance is {Balance}");
            }
        }
    }
}
