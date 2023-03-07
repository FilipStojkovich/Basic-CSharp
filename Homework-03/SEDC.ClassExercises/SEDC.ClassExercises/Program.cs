//Exercise 4

string[] wordsArray = new string[5] { "This", "is", "the", "fourth", "exercise" };
double[] decimalArray = new double[5] { 1.5, 2.5, 3.5, 4.5, 5.5 };
char[] characterArray = new char[5] { 'F', 'i', 'l', 'i', 'p' };
bool[] boolArray = new bool[5] { true, false, false, true, true };
int[][] twoDArray = new int[2][] { new int[] { 1, 2 }, new int[] { 4, 5 } };

//Exercise 5
int[] integerArray = new int[5];

Console.WriteLine("Please enter your first number:");
int firstNumber = int.Parse(Console.ReadLine());
integerArray[0] = firstNumber;

Console.WriteLine("Please enter your second number:");
int secondNumber = int.Parse(Console.ReadLine());
integerArray[1] = secondNumber;

Console.WriteLine("Please enter your third number:");
int thirdNumber = int.Parse(Console.ReadLine());
integerArray[2] = thirdNumber;

Console.WriteLine("Please enter your fourth number:");
int fourthNumber = int.Parse(Console.ReadLine());
integerArray[3] = fourthNumber;

Console.WriteLine("Please enter your fifth number:");
int fifthNumber = int.Parse(Console.ReadLine());
integerArray[4] = fifthNumber;

int sum = 0;
foreach (int number in integerArray)
{
    sum += number;
}

Console.WriteLine("The sum of the numbers you entered is " + sum);

//Exercise 6
string[] namesArray = new string[Int16.MaxValue];
int index = 0;
string input = "";

do
{
    Console.Write("Enter a name: ");
    input = Console.ReadLine();
    namesArray[index] = input;
    index++;

    Console.Write("Do you want to enter another name? (Y/N): ");
    input = Console.ReadLine();
}
while (input.ToUpper() == "Y");

Console.WriteLine("All entered names:");
for (int i = 0; i < index; i++)
{
    Console.WriteLine(namesArray[i]);
}

Console.ReadLine();