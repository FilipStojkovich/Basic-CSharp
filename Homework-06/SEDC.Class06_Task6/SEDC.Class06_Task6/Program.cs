using SEDC.Class06_Task6;
using System.ComponentModel.DataAnnotations;

internal class Program
{
    public static void Main(string[] args)
    {
        var customers = new Customers[] {
        new Customers("Bob Bobsky", "1234-4567-3245", 1234, 1000),
        new Customers("Walter White", "6543-1734-8326", 9275, 5000),
        new Customers("Filip Stojkovich", "7777-7777-7777", 7429, 10000)
        };


        Console.WriteLine("Welcome to the ATM app!\nPlease enter your card number:");
        string userInputCardNumber = string.Format("{0:####-####-####}", Console.ReadLine());

        Console.WriteLine("Please enter your pin:");
        int userInputPin = int.Parse(Console.ReadLine());

        for (int i = 0; i < customers.Length; i++)
        {
            if (customers[i].CardNumber.Contains(userInputCardNumber) && customers[i].Pin.Equals(userInputPin))
            {
                Console.WriteLine($"Welcome {customers[i].FullName}.\nWhat would you like to do:\n1. Check Balance\n2. Cash Withdrawal\n3. Cash Deposit");
                int userInputAction = int.Parse(Console.ReadLine());

                if (userInputAction == 1)
                {
                    customers[i].CheckBalance();
                    break;
                }
                else if (userInputAction == 2)
                {
                    Console.WriteLine("How much money do you want to withdraw?");
                    int userInputMoneyWithdraw = int.Parse(Console.ReadLine());

                    customers[i].WithdrawMoney(userInputMoneyWithdraw);
                    break;
                }
                else if (userInputAction == 3)
                {
                    Console.WriteLine("How much money do you want to deposit?");
                    int userInputDepositMoney = int.Parse(Console.ReadLine());

                    customers[i].CashDeposit(userInputDepositMoney);
                    break;
                }
                Console.ReadLine();
            }
            else if(i == customers.Length - 1)
            {
                Console.WriteLine("There is no account with that card number. Would you like to register?(Y/N)");
                string userInputRegister = Console.ReadLine();


                if (userInputRegister.ToLower() == "y")
                {

                    Console.WriteLine("Please enter your name");
                    string userInputFullName = Console.ReadLine();

                    Console.WriteLine("Please enter the amount of money on this card(max 10000)");
                    int userInputMoneyAmountOnCard = int.Parse(Console.ReadLine());

                    customers = new Customers[]
                    {
                        new Customers(userInputFullName, userInputCardNumber, userInputPin, userInputMoneyAmountOnCard)
                    };

                    Console.WriteLine($"Hello there {userInputFullName}. Glad to have you on the app!\nYou can now withdraw money from our ATM's! You have {userInputMoneyAmountOnCard} $$ on your card!");
                    break;
                }
                else
                {
                    Console.WriteLine("Thank you for using out ATM app.");
                }
            }           
        }
        //var endProgram = Console.ReadLine();
        //Console.WriteLine(endProgram);
    }
}