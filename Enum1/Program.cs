namespace Enum1
{
    using System;

    enum TrafficLight
    {
        Red = 1,
        Yellow,
        Green
    }

    class TrafficControl
    {
        public static void ActionBasedOnTrafficLight(TrafficLight light)
        {
            switch (light)
            {
                case TrafficLight.Red:
                    Console.WriteLine("Stop! The light is red.");
                    break;
                case TrafficLight.Yellow:
                    Console.WriteLine("Get ready! The light is yellow.");
                    break;
                case TrafficLight.Green:
                    Console.WriteLine("Go! The light is green.");
                    break;
                default:
                    Console.WriteLine("Invalid traffic light status.");
                    break;
            }
        }
    }

    class Program
    {
        static void Main()
        {
            TrafficLight currentLight = TrafficLight.Green;
            TrafficControl.ActionBasedOnTrafficLight(currentLight); // Output: Go! The light is green.
        }
    }

}
