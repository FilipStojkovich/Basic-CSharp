// Task 1
using System.Net.Cache;

Console.WriteLine("Type something:");
string userInput = Console.ReadLine();
Console.WriteLine(userInput.Substring(userInput.Length - 5));

// Task 2
Console.WriteLine("Write a sentence:");
string userInput1 = Console.ReadLine();
string[] letters = userInput1.Split(' ');
foreach (string letter in letters)
{
    Console.WriteLine(letter);
}

// Task 3
Console.WriteLine("Enter the number:");
int userNumber = int.Parse(Console.ReadLine());

SumOfDigitsInNumber(userNumber);
void SumOfDigitsInNumber(int number)
{
    int sum = 0, reminder;

    while (number > 0)
    {
        reminder = number % 10;
        sum = sum + reminder;
        number = number / 10;
    }
    Console.WriteLine($"The sum of the digits is : {sum}");
}

// Task 4

Console.WriteLine("Please enter your birth date: (dd-mm-year)");
DateTime userInputBirthDate = DateTime.Parse(Console.ReadLine());

void AgeCalculator(DateTime birthDate)
{
    DateTime today = DateTime.Now; 
    int age = today.Year - birthDate.Year;

    if (today.Month < birthDate.Month || (today.Month == birthDate.Month && today.Day < birthDate.Day))
        age--;

    Console.WriteLine($"You are {age} years old");
}

AgeCalculator(userInputBirthDate);

Console.ReadLine();