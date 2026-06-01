namespace ConsoleApp1
{
    public class BankAccount
    {
        public string AccountNumber { get; set; }
        public string AccountName { get; set; }
        public decimal Balance {  get; private set; }

        //contructors
        // This is a cons that has no params.
        public BankAccount()
        {

        }

        //const that takes in 1 parameter
        public BankAccount(string accountNumber)
        {
            //AccountNumber = accountNumber;
            //accountNumber = AccountNumber;
        }

        public BankAccount(string accountName, string accountNumber)
        {
        }

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
