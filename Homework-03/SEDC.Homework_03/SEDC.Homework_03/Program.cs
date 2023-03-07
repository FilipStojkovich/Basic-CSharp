// Task 1
 int[] intArray = new int[6];
 int sum = 0;

for(int i = 0; i < intArray.Length; i++)
{
    Console.WriteLine($"Enter integer no. {i + 1}");
    int userInput = int.Parse(Console.ReadLine());

    if(userInput % 2 == 0)
    {
        sum += userInput;
    }
}

Console.WriteLine("The sum of the even numbers is " + sum);

// Task 2

string[] studentsG1 = new string[5] { "Filip", "Martin", "Mila", "Damjan", "Tosho" };
string[] studentsG2 = new string[5] { "Zdravko", "Petko", "Stanko", "Branko", "Trajko" };

Console.WriteLine("Enter student group: (1/2)");
int userInputGroup = int.Parse(Console.ReadLine());

if (userInputGroup == 1)
{
    foreach (string student in studentsG1)
    {
        Console.WriteLine(student);
    }
}
else if (userInputGroup == 2)
{
    foreach (string student in studentsG2)
    {
        Console.WriteLine(student);
    }
}
else
{
    Console.WriteLine("Please enter a valid number!");
}


Console.ReadLine();