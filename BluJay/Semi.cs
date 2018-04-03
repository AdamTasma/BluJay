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
                    case 1:
                        Console.WriteLine("You move forward at an accelerating pace.");                       
                        return direction;
                    case 2:
                        Console.WriteLine("You turn to the left.");
                        return direction;
                    case 3:
                        Console.WriteLine("You turn to the right.");
                        return direction;
                    case 4:
                        Console.WriteLine("You hit the brakes so quickly that your trailer careens slightly to the side, jack knifing to a stop.");
                        return direction;
                    default:
                        Console.WriteLine("please enter a numeric between 1-4.");
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
