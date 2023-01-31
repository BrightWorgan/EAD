using EAD_Lab1;

namespace BankUnitTests
{
    public class AccountTest
    {
        // Sample test we covered in Class 1
        [TestClass]
        public class UnitTest1
        {
            [TestMethod]
            public void TestMethod1()
            {
                BankAccount b = new BankAccount("903555", "12344544", 1000);
                Assert.IsNotNull(b);
            }
        }


        // Withdrawl function Test GoldenPath
        [TestClass]
        public class WithdrawlFunctionTestPaass
        {
            [TestMethod]
            public void TestMethod1()
            {
                BankAccount bacc = new BankAccount("903555", "12344544", 1000);
                bacc.Deposit(1000);
                bacc.Withdraw(2000);
                Assert.AreEqual(bacc.Balance, -1000);
            }
        }

        // Withdrawl function Test 
        [TestClass]
        public class WithdrawlFunctionTestFail
        {
            [TestMethod]
            public void TestMethod1()
            {
                BankAccount bacc = new BankAccount("903555", "12344544", 1000);
                bacc.Deposit(1000);
                bacc.Withdraw(2000);
                bacc.Withdraw(100);
            }
        }


        // Withdrawl function Test Multiple Deposits
        [TestClass]
        public class WithdrawlFunctionTestMultipleDeposits
        {
            [TestMethod]
            public void TestMethod1()
            {
                BankAccount bacc = new BankAccount("903555", "12344544", 1000);
                bacc.Withdraw(3260);
                bacc.Withdraw(900);
                bacc.Withdraw(1200);
                bacc.Withdraw(250);
                bacc.Withdraw(50);
                bacc.Withdraw(50);
                Assert.AreEqual(bacc.Balance, 0);
            }
        }

        // Deposit function Test GoldenPath
        [TestClass]
        public class DepositFunctionTest
        {
            [TestMethod]
            public void TestMethod1()
            {
                BankAccount bacc = new BankAccount("903555", "12344544", 1000);
                bacc.Deposit(1000);
                Assert.AreEqual(bacc.Balance, 1000);
            }
        }

        // Deposit function Test GoldenPathNoOD
        [TestClass]
        public class DepositFunctionTestNoOD
        {
            [TestMethod]
            public void TestMethod1()
            {
                BankAccount bacc = new BankAccount("903555", "12344544", 0);
                bacc.Deposit(25000);
                Assert.AreEqual(bacc.Balance, 25000);
            }
        }

        // Deposit function Test Multiple Deposits
        [TestClass]
        public class DepositFunctionTestMultipleDeposits
        {
            [TestMethod]
            public void TestMethod1()
            {
                BankAccount bacc = new BankAccount("903555", "12344544", 1000);
                bacc.Deposit(3260);
                bacc.Deposit(900);
                bacc.Deposit(1200);
                bacc.Deposit(250);
                bacc.Deposit(50);
                bacc.Deposit(50);
                Assert.AreEqual(bacc.Balance, 5710);
            }
        }

        /*
       // // Deposit function Test minus number
      [TestClass]
       public class DepositFunctionTestMinusNum
       {
           [TestMethod]
           public void TestMethod1()
           {
               BankAccount bacc = new BankAccount("903555", "12344544", 1000);
               bacc.Withdraw(1000);
               bacc.Deposit(-100);
               Assert.Fail();
           }
       }
       */
    }


}
// Deposit function Test GoldenPath
// Deposit function Test GoldenPath with no Overdraft
// Deposit function Test Multiple Deposits
// Deposit function Test Fail
// Deposit function Test minus number
// Deposit function Test 0
// Deposit function Test with a huge number


// Withdrawl function Test GoldenPath
// Withdrawl function Test minus number
// Withdrawl function Test 0
// Withdrawl function Test with a huge number
// Withdrawl function Test with too low of a balance/ overdraft limit reached
// Withdrawl function Test with overdraft set at 0


// adding a new BankAccount with correct inputs for the BankAccount's Fields (GoldenPath)
// wrong inputs for BankAccount Fields (string nut not a number)
// adding a new BankAccount with one field missing
// wrong inputs for BankAccount Fields
