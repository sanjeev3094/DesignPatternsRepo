using System;
using DesignPatterns.Observer.Observable;
using DesignPatterns.Observer.Observers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestDesignPatterns
{
    [TestClass]
    public class ObserverPatternTests
    {
        [TestMethod]
        public void TestObserverPatternMethod()
        {
            WeatherStation weatherStation = new WeatherStation();
            CurrentConditionDisplay display = new CurrentConditionDisplay(weatherStation);

            weatherStation.SetMeasurements(40, 95, 700);
        }
    }
}
