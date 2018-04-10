using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BluJay
{
    class SUV
    {
        int previousDirection;

        public SUV()
        {

        }

        public void SuvDirection(int trafficLightState)
        {
            Console.WriteLine("What direction would you like to go?\n" +
                              "1) Move forward\n" +
                              "2) Turn left\n" +
                              "3) Turn right\n" +
                              "4) Run over the ford pinto in front of you");
            if (int.TryParse(Console.ReadLine(), out int direction))
            {
                switch (direction)
                {
                    case 1: //move forward
                        if (previousDirection != 1)
                        {
                            Console.WriteLine("You start to accelerate forward.");
                            previousDirection = 1;
                        }
                        else
                        {
                            Console.WriteLine("\nError! Experiencing some highway hypnosis friend? You are already moving forward. Please try a different direction.");
                            SuvDirection(trafficLightState);
                        }
                        break;
                    case 2: //turn left
                        if (trafficLightState == 3)
                        {
                            Console.WriteLine("\nAfter waiting for the light to change, you turn left at the intersection.");
                            previousDirection = 2;
                        }
                        else
                        {
                            Console.WriteLine("You are unable to turn left at the intersection, perhaps you should wait for the right of way.");
                            SuvDirection(trafficLightState);
                        }
                        break;
                    case 3:
                        Console.WriteLine("You turn right at the intersection.");
                        previousDirection = 3;
                        break;
                    case 4:
                        if (previousDirection != 1)
                        {
                            Console.WriteLine("You are unable to run over the ford pinto because you are not currently moving forward.");
                        }
                        else
                        {
                            Console.WriteLine("You speed forwrd, feeling powerful, the pinto growing larger in your windshield." +
                                "Your front bumper brushes the back of the smaller vehicle, and in one cathartic moment you crush the pinto under your wheels," +
                                "climbing over the ruined vehicle as you create a reverse snowman made out of scheering metal. The pinto is no more as you emerge victorious.");
                        }
                        break;
                }
            }
            else
            {
                Console.WriteLine("Unable to understand input, please enter a numeric between 1-4");
                SuvDirection(trafficLightState);
            }
        }
    }
}
