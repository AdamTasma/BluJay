using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BluJay
{
    class Semi
    {
        int previousDirection;

        public Semi()
        {

        }

        public int SemiDirection()
        {
            Console.WriteLine("\nWhich direction would you like to go?\n" +   
                              "1) Move foward \n" +
                              "2) Turn left\n" +
                              "3) Turn right\n" +
                              "4) Jack knife to a stop");
            if (int.TryParse(Console.ReadLine(), out int direction))
            {
                switch (direction)
                {
                    case 1: //move forward
                        if (previousDirection != 1)
                        {
                            Console.WriteLine("\nYou move forward at an accelerating pace.");
                            previousDirection = 1;
                            return direction;
                        }
                        else
                        {
                            Console.WriteLine("\nError! Experiencing some highway hypnosis friend? You are already moving forward. Please try a different direction.");
                            SemiDirection();
                            break;
                        }
                    case 2: //turn left
                        if (previousDirection != 4)
                        {
                            Console.WriteLine("\nYou turn to the left.");
                            previousDirection = 2;
                            return direction;
                        }
                        else
                        {
                            Console.WriteLine("\nYou can't turn yet, your trailer is still jack knifed. Try moving forward first.");
                            SemiDirection();
                            break;
                        }
                    case 3: //turn right
                        if (previousDirection != 4)
                        {
                            Console.WriteLine("\nYou turn to the right.");
                            previousDirection = 3;
                            return direction;
                        }
                        else
                        {
                            Console.WriteLine("\nYou can't turn yet, your trailer is still jack knifed. Try moving forward first.");
                            SemiDirection();
                            break;
                        }
                    case 4: //jack knife to a stop
                        if (previousDirection != 4)
                        {
                            Console.WriteLine("\nYou hit the brakes so quickly that your trailer careens slightly to the side, jack knifing to a stop.");
                            previousDirection = 4;
                            return direction;
                        }
                        else
                        {
                            Console.WriteLine("\nYou might still be experiencing vertigo from braking so hard, you are already stopped! Try moving forward to straighten the semi out.");
                            SemiDirection();
                            break;
                        }
                    default:
                        Console.WriteLine("\nplease make sure to enter a numeric between 1-4.");
                        SemiDirection();
                        break;
                }
            }
            else
            {
                Console.WriteLine("\nPlease only enter a numeric keystroke and hit enter.");
                SemiDirection();
                return direction;
            }
            return -1;
        }
    }


}
