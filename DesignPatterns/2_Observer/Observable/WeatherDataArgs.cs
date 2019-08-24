using System;

namespace DesignPatterns.Observer.Observable
{
    public class WeatherDataArgs : EventArgs
    {
        public WeatherData WeatherData { get; private set; }

        public WeatherDataArgs(float temperature, float humidity, float pressure)
        {
            WeatherData = new WeatherData
            {
                Temperature = temperature,
                Humidity = humidity,
                Pressure = pressure
            };
        }
    }
}
