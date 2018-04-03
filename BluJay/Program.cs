using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BluJay
{
    class Program
    {
        static void Main()
        {
            TrafficLight tl = new TrafficLight();
            Console.WriteLine("Welcome to a traffic accident waiting to happen!");
            ChooseCar();
            Console.WriteLine("Up ahead a traffic light is " + tl.trafficLightColor);
            Console.WriteLine("don't end yet");
            Console.ReadLine();
        }

        static void ChooseCar()
        {
            Console.WriteLine("Which car would you like to drive? enter 1 for an 18 wheeler semi, enter 2 for an SUV");
            if (int.TryParse(Console.ReadLine(), out int CarChoice))
            {
                if (CarChoice == 1)
                {
                    Semi s = new Semi();
                }
                else if (CarChoice == 2)
                {
                    //create suv object
                }
            }
            else
            {
                Console.WriteLine("Oh no! Maybe roadrage has clouded your ability to answer correctly. Please make sure to only enter a numeric 1 or 2.");
                ChooseCar();
            }
            Console.ReadLine();
        }
    }
}
