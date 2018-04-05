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
            Semi s = new Semi();
            SUV suv = new SUV();
            string currentCar = "";

            Console.WriteLine("Welcome to a traffic accident waiting to happen!");
            ChooseCar(s, suv, currentCar);
        }

        public static string ChooseCar(Semi s, SUV suv, string currentCar)
        {
            Console.WriteLine("Which car would you like to drive?\n" + 
                              "1) for an 18 wheeler semi\n" + 
                              "2) for an SUV");
            if (int.TryParse(Console.ReadLine(), out int carChoice))
            {
                if (carChoice == 1)
                {
                    currentCar = "semi";
                    ShowMenu(s, suv, currentCar);
                }
                else if (carChoice == 2)
                {
                    currentCar = "suv";
                    ShowMenu(s, suv, currentCar);
                }
            }
            else
            {
                Console.WriteLine("Oh no! Maybe roadrage has clouded your ability to answer correctly. Please make sure to only enter a numeric 1 or 2.");
                ChooseCar(s, suv, currentCar);
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
                        if (currentCar == "semi")
                        {
                            s.SemiDirection();
                        }
                        else if(currentCar == "suv")
                        {
                            suv.SuvDirection();
                        }
                        break;
                    case 2:
                        tl.trafficLightState++;
                        Console.WriteLine();
                        break;
                    case 3:
                        ChooseCar(s, suv, currentCar);
                        break;
                    case 4:
                        Console.WriteLine("\nLogging you out.");
                        System.Threading.Thread.Sleep(500);
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("-1");
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
