using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BankAccountManagement
{
    class BankAccount
    {
        public string AccountNumber { get; set; }
        public string AccountHolder { get; set; }
        public double Balance { get; set; }
        public BankAccount()
        {
            AccountNumber = "Unknown";
            AccountHolder = "Unknown";
            Balance = 0;
        }

        public BankAccount(string accountNumber, string accountHolder, double balance)
        {
            AccountNumber = accountNumber;
            AccountHolder = accountHolder;
            Balance = balance;
        }

        public void Deposit()
        {
            double MoneyDeposit;
            do
            {
                Console.Write("The amount you want to deposit into your account: ");
                MoneyDeposit = double.Parse(Console.ReadLine());
                if (MoneyDeposit <= 0)
                {
                    Console.WriteLine("The money you send is not real");
                    Console.WriteLine("Do you want to continue depositing money?");
                    Console.WriteLine("A/a. Yes");
                    Console.WriteLine("B/b. No");
                    char choice = Convert.ToChar(Console.ReadLine());
                    if (choice == 'B' || choice == 'b')
                    {
                        Console.WriteLine("Exit Depositing");
                        break;
                    }
                }
                else
                {
                    Balance += MoneyDeposit;
                    Console.WriteLine($"Deposited {MoneyDeposit:C} into account {AccountNumber}. New balance: {Balance:C}");
                }
            } while (MoneyDeposit <= 0);
        }
        public void Withdraw()
        {
            if(Balance <= 0)
            {
                Console.WriteLine("Your account has no money yet");
            }
            else
            {
                double MoneyWithdraw;
                do
                {
                    Console.Write("The amount of money you want to withdraw from your account: ");
                    MoneyWithdraw = double.Parse(Console.ReadLine());
                    if (MoneyWithdraw <= 0)
                    {
                        Console.WriteLine("The money you send is not real");
                    }
                    else if (Balance < MoneyWithdraw)
                    {
                        Console.WriteLine("Your balance does not meet the required withdrawal amount");
                    }
                    else
                    {
                        Balance -= MoneyWithdraw;
                        Console.WriteLine($"Withdrawn {MoneyWithdraw:C} from account {AccountNumber}. New balance: {Balance:C}");
                        continue;
                    }
                    Console.WriteLine("Do you want to continue withdrawing money?");
                    Console.WriteLine("A/a. Yes");
                    Console.WriteLine("B/b. No");
                    char choice = Convert.ToChar(Console.ReadLine());
                    if (choice == 'B' || choice == 'b')
                    {
                        Console.WriteLine("Exit Withdrawing");
                        break;
                    }
                } while (Balance < MoneyWithdraw || MoneyWithdraw <= 0);
            } 
        }
        public void DisplayAccountDetails()
        {
            Console.WriteLine($"Account Holder: {AccountHolder}");
            Console.WriteLine($"Account Number: {AccountNumber}");
            Console.WriteLine($"Balance: {Balance:C}");
        }
    }
}
