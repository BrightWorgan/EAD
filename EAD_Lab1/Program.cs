// See https://aka.ms/new-console-template for more information
namespace EAD_Lab1
{
    // test class
    class BankAccountTest
    {
        public static void Main()
        {
            BankAccount b = new BankAccount("903555", "12344544", 1000);
            Console.WriteLine(b.ToString());

            b.Deposit(100);

            if (b.Withdraw(200))
            {
                Console.WriteLine("Withdrawal was successful");
                Console.WriteLine(b.ToString());
            }
            else
            {
                Console.WriteLine("Withdrawal failed");
            }

            b.Deposit(500);
            Console.WriteLine(b.ToString());

            //b.PrintTransactionHistory();
            Console.WriteLine("Transactions: ");
            foreach(Double tx in b)
            {
                Console.WriteLine(tx);
                Console.WriteLine();
            } 
        }
    }

}

