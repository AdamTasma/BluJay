using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BluJay
{
    class Semi
    {
        int direction;
        int previousDirection;

        public Semi()
        {
            direction = UserDirection();
        }

        public int UserDirection()
        {
            Console.WriteLine("Which direction would you like to go?\nEnter 1 for moving foward \nEnter 2 to turn left\n Enter 3 to turn right\nEnter 4 to jackknife to a stop");
            if (int.TryParse(Console.ReadLine(), out int userInput))
            {
                direction = userInput;

                switch (userInput)
                {
                    case 1: //move forward
                        if (previousDirection != 1)
                        {
                            Console.WriteLine("You move forward at an accelerating pace.");
                            previousDirection = 1;
                            return direction;
                        }
                        else
                        {
                            Console.WriteLine("Error! Experiencing some highway hypnosis friend? You are already moving forward. Please try a different direction.");
                            UserDirection();
                            break;
                        }
                    case 2: //turn left
                        if (previousDirection != 4)
                        {
                            Console.WriteLine("You turn to the left.");
                            previousDirection = 2;
                            return direction;
                        }
                        else
                        {
                            Console.WriteLine("You can't turn yet, your trailer is still jack knifed. Try moving forward first.");
                            UserDirection();
                            break;
                        }
                    case 3: //turn right
                        if (previousDirection != 4)
                        {
                            Console.WriteLine("You turn to the right.");
                            previousDirection = 3;
                            return direction;
                        }
                        else
                        {
                            Console.WriteLine("You can't turn yet, your trailer is still jack knifed. Try moving forward first.");
                            UserDirection();
                            break;
                        }
                    case 4: //jack knife to a stop
                        if (previousDirection != 4)
                        {
                            Console.WriteLine("You hit the brakes so quickly that your trailer careens slightly to the side, jack knifing to a stop.");
                            previousDirection = 4;
                            return direction;
                        }
                        else
                        {
                            Console.WriteLine("You might still be experiencing vertigo, you are already stopped! Try moving forward to straighten the semi out.");
                            break;
                        }
                    default:
                        Console.WriteLine("please make sure toenter a numeric between 1-4.");
                        UserDirection();
                        break;
                }
            }
            else
            {
                Console.WriteLine("Please only enter a numeric keystroke and hit enter.");
                UserDirection();
                return direction;
            }
            return -1;
        }
    }


}
