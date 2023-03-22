using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_08_Task3
{
    public class Animal
    {
        public Animal(string name, string color, int age, Gender genderType)
        {
            Name = name;
            Color = color;
            Age = age;
            GenderType = genderType;
        }

        public string Name { get; set; }
        public string Color { get; set; }
        public int Age { get; set; }
        public Gender GenderType { get; set; }
        
        
        public enum Gender
        {
            Male,
            Female
        }
    }
}
