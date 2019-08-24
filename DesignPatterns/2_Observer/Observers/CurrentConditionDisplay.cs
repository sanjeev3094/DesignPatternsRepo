using DesignPatterns.Observer.Observable;
using System;

namespace DesignPatterns.Observer.Observers
{
    public class CurrentConditionDisplay : IDisplayElement
    {
        private readonly IWeatherDataPublisher _weatherDataPublisher;
        private float _temperature;
        private float _humidity;
        private float _pressure;

        public CurrentConditionDisplay(IWeatherDataPublisher weatherDataPublisher)
        {
            _weatherDataPublisher = weatherDataPublisher;
            _weatherDataPublisher.MeasurementDataChanged += OnMeasurementDataChanged;
        }

        private void OnMeasurementDataChanged(WeatherData weatherData)
        {
            _temperature = weatherData.Temperature;
            _humidity = weatherData.Humidity;
            _pressure = weatherData.Pressure;

            Display();
        }

        public void Display()
        {
            Console.WriteLine("Current Conditions: ");
            Console.WriteLine($"Temperature: {_temperature}");
            Console.WriteLine($"Humidity: {_humidity}");
            Console.WriteLine($"Pressure: {_pressure}");
        }
    }
}
