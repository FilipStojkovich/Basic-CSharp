Console.WriteLine("Exercise 5\n");

int numberOfBranches = 12;
int numberOfApples = 8;
double basketCapacity = 5;

Console.WriteLine("Please enter number of trees:");
bool userInput = int.TryParse(Console.ReadLine(), out int numberOfTrees);

if (userInput)
{
    int numberOfTotalBranches = numberOfBranches * numberOfTrees;
    int numberOfTotalApples = numberOfTotalBranches * numberOfApples;
    double numberOfBaskets = numberOfTotalApples / basketCapacity;

    if (numberOfBaskets % 2 != 0)
    {
        numberOfBaskets = Math.Ceiling(numberOfBaskets);
    }
    Console.WriteLine("You will need " + numberOfBaskets + " baskets to collect all the apples.\n");
}

Console.WriteLine("Exercise 6\n");

Console.WriteLine("Please enter the first number:");
int userInput1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Please enter the second number:");
int userInput2 = Convert.ToInt32(Console.ReadLine());

if (userInput1 > userInput2)
{
    Console.WriteLine("The bigger number is: " + userInput1);
} else if(userInput1 < userInput2)
{
    Console.WriteLine("The bigger number is " + userInput2);
} else
{
    Console.WriteLine("The numbers are equal");
}

if (userInput1 % 2 == 0)
{
    Console.WriteLine("The number " + userInput1 + " is even");
} else
{
    Console.WriteLine("The number " + userInput1 + " is odd");
}

if(userInput2 % 2 == 0)
{
    Console.WriteLine("The number " + userInput2 + " is even");
} else
{
    Console.WriteLine("The number " + userInput2 + " is odd\n");
}

Console.WriteLine("Exercise 7\n");

Console.WriteLine("Please enter a number from 1 to 3:");
int userInputNumber = Convert.ToInt16(Console.ReadLine());

switch (userInputNumber)
{
    case 1:
        Console.WriteLine("You got a new car!");
        break;
    case 2:
        Console.WriteLine("You got a new plane!");
        break;
    case 3:
        Console.WriteLine("You got a new bike!");
        break;
    default:
        Console.WriteLine("Error: Please enter a number from 1 to 3!");
        break;
}


Console.ReadLine();