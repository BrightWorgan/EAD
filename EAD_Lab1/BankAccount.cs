using System.Collections;
using System.Text;

namespace EAD_Lab1
{
    // CA3 sample solution - bank account

    // a bank account
    public class BankAccount : IEnumerable
    {
        // fields
        private String sortCode;
        public String SortCode {
            get { return sortCode; } }

        private String accountNo;
        public String AccountNo { get { return accountNo; } }

        private double balance;                 // €

        public double Balance { get { return balance; } }

        private double overdraftLimit;          // €  
        public double OverdraftLimit { get { return overdraftLimit; } }

        private const int MaxTransactions = 100;

        private double[] transactionHistory;   // a record of amounts deposited and withdrawn

        private int nextTransaction;           // the next free slot in the transactionHistory array 

        // constructor
        public BankAccount(String sortCode, String accountNo, double overdraftLimit)
        {
            int.proof Int = int.Parse(sortCode);
            this.sortCode = sortCode;
            this.accountNo = accountNo;
            this.balance = 0;
            this.overdraftLimit = overdraftLimit;

            transactionHistory = new double[MaxTransactions];
            nextTransaction = 0;                // no transaction to date
        }

        // overloaded constructor - chain
        public BankAccount(String sortCode, String accountNo)
            : this(sortCode, accountNo, 0)
        {
        }


        // deposit money in the account
        public void Deposit(double amount)                      // assume amount is positive
        {
            balance += amount;

            // record in transaction history
            transactionHistory[nextTransaction++] = amount;
        }

        // withdraw money if there are sufficient funds
        public bool Withdraw(double amount)                     // assume amount is positive
        {
            if ((balance + overdraftLimit) > amount)
            {
                balance -= amount;
                transactionHistory[nextTransaction++] = amount * -1;
                return true;                            // withdraw was succesful
            }
            else                                        // unsufficient funds
            {
                throw new ApplicationException("\n\t*** ERROR: Unsufficient Funds! ***");
            }
        }

        // print account details to the console
        public override string ToString()
        {
            StringBuilder sb1 = new();
            sb1.Append("sort code: " + sortCode + " account no: " + accountNo + " overdraft limit: " + overdraftLimit + " balance: " + balance);
            
            if (nextTransaction == 0)
            {
                sb1.Append(" | No transactions yet");
            }
            else
            {
                sb1.Append(" | Transaction History: ");
                for (int i = 0; i < nextTransaction; i++)
                {
                    sb1.Append(transactionHistory[i] + " ");
                }
               
            }
            return sb1.ToString();
        }

        // print the transaction history
        public void PrintTransactionHistory()
        {
        
        }


        public IEnumerator GetEnumerator()
        {
            return transactionHistory.GetEnumerator();

        }

    }

    
}
