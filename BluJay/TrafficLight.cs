using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BluJay
{
    public class TrafficLight
    {
        public int trafficLightState = 0;
        public string trafficLightColor;
        List<string> TrafficLights = new List<string>() { "green", "yellow", "red", "left-turn-green" }; 

        public TrafficLight()
        {
            trafficLightColor = TrafficLightChange(trafficLightState);
        }

        public string TrafficLightChange(int trafficLightState)
        {
            if(trafficLightState > 3)
            {
                trafficLightState = 0;
                System.Threading.Thread.Sleep(300);
                Console.WriteLine("\nYou waited so long the traffic light turned green again.");
            }

            trafficLightColor = TrafficLights[trafficLightState];
            return trafficLightColor;
        }
    }
}
