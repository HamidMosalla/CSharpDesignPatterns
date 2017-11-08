using System;
using Observer.BuiltInObserver;
using Observer.BuiltInObserver.Observer;
using Observer.BuiltInObserver.Subject;
using Observer.ObserverObjects;
using Observer.SubjectObjects;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Observer pattern

            // Configure Observer pattern

            ConcreteSubject s = new ConcreteSubject();

            s.Attach(new ConcreteObserver(s, "X"));

            s.Attach(new ConcreteObserver(s, "Y"));

            s.Attach(new ConcreteObserver(s, "Z"));


            // Change subject and notify observers

            s.SubjectState = "ABC";

            s.Notify();

            #endregion

            #region .Net implementation of observer pattern

            var weatherReport = new WeatherReport();
            var germanyWeatherReport = new GermanyWeatherStation();
            var iranWeatherReport = new IranWeatherStation();
            var usWeatherReport = new UnitedStateWeatherStation();

            weatherReport.WeatherChanged += germanyWeatherReport.GermanyWeatherChanged;
            weatherReport.WeatherChanged += iranWeatherReport.IranWeatherChanged;
            weatherReport.WeatherChanged += usWeatherReport.UnitedStateWeatherChanged;

            weatherReport.ReportWeather(new WeatherEventArgs(temperature: 30));

            #endregion

            Console.ReadKey();
        }
    }
}
