using System;
namespace BankAccountManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount BankAccount1 = new BankAccount("123456789", "John Doe", 50000);
            BankAccount BankAccount2 = new BankAccount("101112131", "Tom Cruise", 100000);
            BankAccount BankAccount3 = new BankAccount("415161718", "Harry Potter", 150000);

            Console.WriteLine("===== Bank Account Management =====");

            BankAccount1.DisplayAccountDetails();
            BankAccount1.Deposit();
            BankAccount1.Withdraw();
            BankAccount1.DisplayAccountDetails();

            BankAccount2.DisplayAccountDetails();
            BankAccount2.Deposit();
            BankAccount2.Withdraw();
            BankAccount2.DisplayAccountDetails();

            BankAccount3.DisplayAccountDetails();
            BankAccount3.Deposit();
            BankAccount3.Withdraw();
            BankAccount3.DisplayAccountDetails();
        }
    }
}
