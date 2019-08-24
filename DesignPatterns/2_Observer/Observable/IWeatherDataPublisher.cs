using System;

namespace DesignPatterns.Observer.Observable
{
    public interface IWeatherDataPublisher
    {
        event EventHandler MeasurementChanged;

        event Action<WeatherData> MeasurementDataChanged;

        WeatherData WeatherData { get; }
    }
}
