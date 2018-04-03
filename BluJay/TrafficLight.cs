using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BluJay
{
    class TrafficLight
    {
        public int trafficLightState = 1;
        public string trafficLightColor;
        List<string> TrafficLights = new List<string>() { "Green", "Yellow", "Red", "Left-Turn-Green" }; 

        public TrafficLight()
        {
            trafficLightColor = TrafficLightChange(trafficLightState);
        }

        public string TrafficLightChange(int trafficLightState)
        {
            trafficLightColor = TrafficLights[trafficLightState];
            return trafficLightColor;
        }
    }
}
