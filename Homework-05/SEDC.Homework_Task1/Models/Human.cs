using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Homework_05.Models
{
    public class Human
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public void GetPersonDetails()
        {
            Console.WriteLine($"Full name: {FirstName} {LastName}, age: {Age}");
        }
    }
}
