int userInput;
int totalMoney = 500;
int userMoneyValue = 0;
string userInputOtherAction;

do
{
    Console.WriteLine("Press 1 to check balance\nPress 2 to withdraw money");
    userInput = int.Parse(Console.ReadLine());

    if (userInput == 1)
    {
        Console.WriteLine($"You have {totalMoney}$ left in your account");
    }
    else if (userInput == 2)
    {
        Console.WriteLine("How much money do you want to withdraw?");
        userMoneyValue = int.Parse(Console.ReadLine());

        if (userMoneyValue <= totalMoney)
        {
            totalMoney = totalMoney - userMoneyValue;
            Console.WriteLine($"You have successfully withdrawn {userMoneyValue}$, {totalMoney}$ left in your account!");
        }
        else if (userMoneyValue > totalMoney)
        {
            Console.WriteLine("You do not have enough money!");
        }
    }
    else
    {
        Console.WriteLine("Please enter a valid option!");
    }
    Console.WriteLine("Do you want to take some other action: (Y/N)");
    userInputOtherAction = Console.ReadLine();
}
while (userInputOtherAction.ToLower() == "y");


Console.ReadLine();
