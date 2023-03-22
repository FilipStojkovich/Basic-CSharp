using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Class06_Task6
{
    public class Customers
    {
        public Customers(string fullName, string cardNumber, int pin, int accountMoney)
        {
            FullName = fullName;
            CardNumber = string.Format("{0:####-####-####}", cardNumber);
            Pin = pin;
            AccountMoney = accountMoney;
        }

        public string FullName { get; set; }
        public string CardNumber { get; set; }
        public int Pin { get; set; }
        public int AccountMoney { get; set; } 


        public void CheckBalance()
        {
            Console.WriteLine($"You have {AccountMoney} $$ in the bank!");
        }


        public void WithdrawMoney(int userInputMoneyWithdraw)
        {
            if(userInputMoneyWithdraw > AccountMoney)
            {
                Console.WriteLine("You don't have enough money!");
            }
            else if(userInputMoneyWithdraw <= AccountMoney)
            {
                AccountMoney = AccountMoney - userInputMoneyWithdraw;
                Console.WriteLine($"You have successfully withdrawn {userInputMoneyWithdraw}, {AccountMoney} $$ left in the bank!\nThank you for using the ATM app.");
            }
            else
            {
                Console.WriteLine("Please enter a number!");
            }
        }

        public void CashDeposit(int userInputCashDeposit)
        {
            if (userInputCashDeposit <= AccountMoney)
            {
                AccountMoney = AccountMoney - userInputCashDeposit;
                Console.WriteLine($"You have successfully made a deposit for {userInputCashDeposit} $$. {AccountMoney} $$ left in the bank!\nThank you for using the ATM app.");
            }
            else if(userInputCashDeposit > AccountMoney)
            {
                Console.WriteLine("You don't have enough money!");
            }
            else
            {
                Console.WriteLine("Please enter a number!");
            }
        }
    }
}
