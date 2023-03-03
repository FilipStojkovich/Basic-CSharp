Console.WriteLine("Task1\n");

Console.WriteLine("Please enter first number:");
int userNum1 = int.Parse(Console.ReadLine());

Console.WriteLine("Please enter second number:");
int userNum2 = int.Parse(Console.ReadLine());

int sum = userNum1 + userNum2;
int diff = userNum1 - userNum2;
int multiply = userNum1 * userNum2;
int divide = userNum1 / userNum2;

Console.WriteLine("Please enter the operation:");
string operation = Console.ReadLine();

switch (operation)
{
    case "+":
        Console.WriteLine("The result is: " + sum);
        break;
    case "-":
        Console.WriteLine("The result is: " + diff);
        break;
    case "*":
        Console.WriteLine("The result is " + multiply);
        break;
    case "/":
        Console.WriteLine("The result is " + divide);
        break;
    default:
        Console.WriteLine("You didn't enter a valid operation");
        break;
}

Console.WriteLine("Task 2\n");

Console.WriteLine("Enter the first number");
double userInput1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter the second number");
double userInput2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter the third number");
double userInput3 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter the fourth number");
double userInput4 = Convert.ToInt32(Console.ReadLine());

double printAverage = (userInput1 + userInput2 + userInput3 + userInput4) / 4;
Console.WriteLine("The average of " + userInput1 + ", " + userInput2 + ", " + userInput3 + ", " + userInput4 + " is " + printAverage);

Console.WriteLine("Task 3\n");

Console.WriteLine("Input the first number:");
int userNumber1 = int.Parse(Console.ReadLine());

Console.WriteLine("Input the second number:");
int userNumber2 = int.Parse(Console.ReadLine());

Console.Write("Before swapping: first number = " + userNumber1 + ", second number = " + userNumber2 + "\n");

userNumber1 = userNumber1 + userNumber2;
userNumber2 = userNumber1 - userNumber2;
userNumber1 = userNumber1 - userNumber2;

Console.WriteLine("After swapping: first number = " + userNumber1 + ", second number = " + userNumber2);


Console.ReadLine();