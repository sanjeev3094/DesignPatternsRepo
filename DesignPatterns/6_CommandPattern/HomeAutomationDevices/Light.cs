using System;

namespace DesignPatterns.CommandPattern.HomeAutomationDevices
{
    public class Light
    {
        private readonly string _location;

        public Light(string location)
        {
            _location = location;
        }

        public void On()
        {
            Console.WriteLine("Light is On...");
        }

        public void Off()
        {
            Console.WriteLine("Light is Off...");
        }
    }
}
