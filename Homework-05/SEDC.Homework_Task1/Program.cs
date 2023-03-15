using SEDC.Homework_05.Models;
using System.Threading.Channels;

namespace SEDC.Homework_05
{
    // Task 1
    internal class Program
    {
        static void Main(string[] args)
        {
            Human human = new Human();

            Console.WriteLine("Enter first name:");
            human.FirstName = Console.ReadLine();

            Console.WriteLine("Enter last name:");
            human.LastName = Console.ReadLine();

            Console.WriteLine("Enter your age:");
            human.Age = int.Parse(Console.ReadLine());

            human.GetPersonDetails();

            Console.ReadLine();
        }
    }
}