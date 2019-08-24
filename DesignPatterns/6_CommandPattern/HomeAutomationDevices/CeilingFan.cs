
namespace DesignPatterns.CommandPattern.HomeAutomationDevices
{
    public enum Speed
    {
        Off = 0,
        Low,
        Medium,
        High
    }

    public class CeilingFan
    {
        private readonly string _location;

        public Speed Speed { get; private set; }

        public CeilingFan(string location, Speed speed = Speed.Off)
        {
            _location = location;
            Speed = speed;
        }

        public void High()
        {
            Speed = Speed.High;
        }

        public void Medium()
        {
            Speed = Speed.Medium;
        }

        public void Low()
        {
            Speed = Speed.Low;
        }

        public void Off()
        {
            Speed = Speed.Off;
        }
    }
}
