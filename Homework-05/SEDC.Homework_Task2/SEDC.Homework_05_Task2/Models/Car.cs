using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Homework_05_Task2.Models
{
    public class Car
    {
        public Car(string model, int speed)
        {
            Model = model;
            Speed = speed;
        }

        public string Model { get; set; }
        public int Speed { get; set; }
        public Driver Driver { get; set; }


        public int CalculateSpeed(Driver driver)
        {
            int speed = driver.Level * Speed;
            return speed;
        }
    }
}
