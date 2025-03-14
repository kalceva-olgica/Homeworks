using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Car_Rasing_Homework
{
   public class Car
    {
        public string Model { get; set; }
        public double Speed { get; set; }
        public Driver Driver { get; set; }

        public Car(string model,double speed)
        {
            Model = model;
            Speed = speed;
            Driver = null;
        }

        // Make a method RaceCars() that will get two
        // Car objects that will determine which car
        // will win and print the result in the console.
        // Make 4 car objects and 4 driver objects.

        public double CalculateSpeed()
        {
            if (Driver == null)
            {

                Console.WriteLine("There is no driver");
                return 0;
            }
            return Speed * Driver.Skill;
        }


        public void RaceCars(Car car1, Car car2)
        {
            int speed1 = car1.CalculateSpeed(); 
            int speed2 = car2.CalculateSpeed(); 

            if (speed1 > speed2)
            {
                Console.WriteLine($"{car1.Model} was faster.");
            }
            else if (speed2 > speed1)
            {
                Console.WriteLine($"{car2.Model} was faster.");
            }
            else
            {
                Console.WriteLine("Something is invalid.");
            }


        }

    }
}
