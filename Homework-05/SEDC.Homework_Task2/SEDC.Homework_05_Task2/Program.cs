using SEDC.Homework_05_Task2.Models;

internal class Program
{

    public static void RaceCars(Car car1, Car car2)
    {
        int speedOfCar1 = car1.CalculateSpeed(car1.Driver);
        int speedOfCar2 = car2.CalculateSpeed(car2.Driver);

        if (speedOfCar1 > speedOfCar2)
        {
            Console.WriteLine($"{car1.Model} wins! {car1.Driver.Name} is driving at {car1.Speed} km/h.!");
        }
        else if (speedOfCar2 > speedOfCar1)
        {
            Console.WriteLine($"{car2.Model} wins! {car2.Driver.Name} is driving at {car2.Speed} km/h.!");
        }
        else
        {
            Console.WriteLine("Nobody wins!");
        }
    }

    static void Main(string[] args)
    {
        do
        {
            Car car1 = new Car("Mazda", 250);
            Car car2 = new Car("Hyundai", 220);
            Car car3 = new Car("Ferrari", 340);
            Car car4 = new Car("Porsche", 300);

            Driver driver1 = new Driver("Bob", 8);
            Driver driver2 = new Driver("Greg", 7);
            Driver driver3 = new Driver("Jill", 6);
            Driver driver4 = new Driver("Anne", 6);

            Console.WriteLine("Select car number 1: Mazda, Hyundai, Ferrari, Porsche");
            string userInputCar1 = Console.ReadLine();

            if (userInputCar1.ToLower() == "mazda")
            {
                car1 = car1;
            }
            else if (userInputCar1.ToLower() == "hyundai")
            {
                car1 = car2;
            }
            else if (userInputCar1.ToLower() == "ferrari")
            {
                car1 = car3;
            }
            else if (userInputCar1.ToLower() == "porsche")
            {
                car1 = car4;
            }
            else
            {
                Console.WriteLine("Please select valid car!");
            }

            Console.WriteLine("Select the driver of car number 1: Bob, Greg, Jill, Anne");
            string userInputDriver1 = Console.ReadLine();

            if (userInputDriver1.ToLower() == "bob")
            {
                car1.Driver = driver1;
            }
            else if (userInputDriver1.ToLower() == "greg")
            {
                car1.Driver = driver2;
            }
            else if (userInputDriver1.ToLower() == "jill")
            {
                car1.Driver = driver3;
            }
            else if (userInputDriver1.ToLower() == "anne")
            {
                car1.Driver = driver4;
            }
            else
            {
                Console.WriteLine("Please select one of the available drivers!");
            }

            Console.WriteLine("Select car number 2: Mazda, Hyundai, Ferrari, Porsche");
            string userInputCar2 = Console.ReadLine();

            if (userInputCar2.ToLower() == "mazda")
            {
                car2 = car1;
            }
            else if (userInputCar2.ToLower() == "hyundai")
            {
                car2 = car2;
            }
            else if (userInputCar2.ToLower() == "ferrari")
            {
                car2 = car3;
            }
            else if (userInputCar2.ToLower() == "porsche")
            {
                car2 = car4;
            }
            else
            {
                Console.WriteLine("Please select valid car!");
            }

            Console.WriteLine("Select the driver of car number 2: Bob, Greg, Jill, Anne");
            string userInputDriver2 = Console.ReadLine();

            if (userInputDriver2.ToLower() == "bob")
            {
                car2.Driver = driver1;
            }
            else if (userInputDriver2.ToLower() == "greg")
            {
                car2.Driver = driver2;
            }
            else if (userInputDriver2.ToLower() == "jill")
            {
                car2.Driver = driver3;
            }
            else if (userInputDriver2.ToLower() == "anne")
            {
                car2.Driver = driver4;
            }
            else
            {
                Console.WriteLine("Please select one of the available drivers!");
            }

            RaceCars(car1, car2);
            Console.ReadLine();

        } while (true);
    }
}
