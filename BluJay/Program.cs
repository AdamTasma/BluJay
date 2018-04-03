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
            string currentCar = "no car";
            Semi s = new Semi();
            SUV suv = new SUV();

            Console.WriteLine("Welcome to a traffic accident waiting to happen!");
            ChooseCar(currentCar);
            ShowMenu(s, suv, currentCar);
            
        }

        public static string ChooseCar(string currentCar)
        {
            Console.WriteLine("Which car would you like to drive?\n" + 
                              "1) for an 18 wheeler semi\n" + 
                              "2) for an SUV");
            if (int.TryParse(Console.ReadLine(), out int carChoice))
            {
                if (carChoice == 1)
                {
                    currentCar = "semi";
                    return currentCar;
                }
                else if (carChoice == 2)
                {
                    currentCar = "suv";
                    return currentCar;
                }
            }
            else
            {
                Console.WriteLine("Oh no! Maybe roadrage has clouded your ability to answer correctly. Please make sure to only enter a numeric 1 or 2.");
                ChooseCar(currentCar);
            }
            return "-1";
        }

        public static void ShowMenu(Semi s, SUV suv, string currentCar)
        {
            TrafficLight tl = new TrafficLight();
            Console.WriteLine("\nUp ahead a traffic light is " + tl.trafficLightColor + ".");
            System.Threading.Thread.Sleep(100);
            Console.WriteLine("\nWhat would you like to do next? please enter the corresponding number.");
            Console.WriteLine("1) Continue to drive your vehicle\n" +
                              "2) Wait for the traffic light to change colors\n" +
                              "3) Change vehicles\n" +
                              "4) Exit your vehicle and come back to reality");
            if(int.TryParse(Console.ReadLine(), out int UserInput))
            {
                switch (UserInput)
                {
                    case 1:
                        s.SemiDirection();
                        break;
                    case 2:
                        Console.WriteLine();
                        break;
                    default:
                        Console.WriteLine();
                        break;
                }
                ShowMenu(s, suv, currentCar);
            }
            else
            {
                Console.WriteLine("Please enter a numeric number that corresponds with your options.");
                ShowMenu(s, suv, currentCar);
            }
        }
    }
}
