using System;

namespace DesignPatterns.CommandPattern.HomeAutomationDevices
{
    public class Stereo
    {
        private int _volume;

        public void On()
        {
            Console.WriteLine("Stereo is On...");
        }

        public void Off()
        {
            Console.WriteLine("Stereo is Off...");
        }

        public void SetCD()
        {
            Console.WriteLine("Setting the CD...");
        }

        public void SetVolume(int volume)
        {
            _volume = volume;
        }
    }
}
