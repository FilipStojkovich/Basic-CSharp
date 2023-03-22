string userInputAnotherNumber;


    Queue<int> intQueue = new Queue<int>();

    Console.WriteLine("Please enter a number:");
    int userNumber1 = int.Parse(Console.ReadLine());

    intQueue.Enqueue(userNumber1);

do
{
    Console.WriteLine("Do you want to enter another number?(y/n)");
    userInputAnotherNumber = Console.ReadLine();

    if (userInputAnotherNumber.ToLower() == "y")
    {
        Console.WriteLine("Please enter a number:");
        int userNumber2 = int.Parse(Console.ReadLine());

        intQueue.Enqueue(userNumber2);
    }
} while (userInputAnotherNumber.ToLower() == "y");

foreach(int number in  intQueue)
{
    Console.WriteLine(number);
}

var endProgram = Console.ReadLine();
Console.WriteLine(endProgram);