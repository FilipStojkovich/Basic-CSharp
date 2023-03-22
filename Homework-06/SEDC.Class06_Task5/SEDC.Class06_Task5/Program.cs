using SEDC.Class06_Task5;
using System;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Channels;

public class Program
{
    public static void Main(string[] args)
    {

        User user1 = new User(1, "BobBobsky", "bobbobsky", new string[] { "You have no messages!" });

        User user2 = new User(2, "JohnDoe", "johndoe", new string[] { "Simon says go to the gym!", "Walter: Let's cook" });

        User user3 = new User(3, "WalterWhite", "walterwhite", new string[] { "You have no messages" });

        Console.WriteLine("Welcome! Please select one of the options below: (1/2)\nLog in\nRegister");
        int userInputOption = int.Parse(Console.ReadLine());

        if (userInputOption == 1)
        {
            Console.WriteLine("Please enter your username:");
            string userInputUsername = Console.ReadLine();

            Console.WriteLine("Please enter your password:");
            string userInputPassword = Console.ReadLine();

            if (userInputUsername == user1.Username && userInputPassword == user1.Password)
            {
                foreach (string message in user1.Messages)
                {
                    Console.WriteLine($"Hello there {user1.Username}. Here are your messages:\n{message}");
                }
            }

            else if (userInputUsername == user2.Username && userInputPassword == user2.Password)
            {
                for (int i = 0; i < user2.Messages.Length; i++)
                {
                    Console.WriteLine($"Hello there {user2.Username}. Here are your messages:\n{user2.Messages[i]}\n{user2.Messages[i + 1]}");
                }
            }
            else if (userInputUsername == user3.Username && userInputPassword == user3.Password)
            {
                for (int i = 0; i < user3.Messages.Length; i++)
                {
                    Console.WriteLine($"Hello there {user3.Username}. Here are your messages:\n{user3.Messages[i]}");
                }
            }
            else
            {
                Console.WriteLine("There is no account with that Username!");
            }
        }
        else if (userInputOption == 2)
        {
            Console.WriteLine("Please enter an ID:");
            int userInputId = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter your Username:");
            string userInputUserName = Console.ReadLine();

            Console.WriteLine("Please enter your Password:");
            string userInputPassWord = Console.ReadLine();

            if (userInputUserName == user1.Username || userInputUserName == user2.Username || userInputUserName == user3.Username)
            {
                Console.WriteLine("Sorry! The Username you entered is taken. Please enter a different Username!");
            }
            else
            {
                User user4 = new User(userInputId, userInputUserName, userInputPassWord, new string[] { $"Welcome {userInputUserName}. We are glad to have you!" });
                Console.WriteLine($"{user1.Id} {user1.Username}\n{user2.Id} {user2.Username}\n{user3.Id} {user3.Username}\n{user4.Id} {user4.Username}");
            }
        }
        else
        {
            Console.WriteLine("Please enter a valid option number!");
        }

        Console.ReadLine();
    }
}
