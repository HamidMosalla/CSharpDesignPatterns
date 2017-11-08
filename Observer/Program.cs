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
            /*
             * More info: https://en.wikipedia.org/wiki/Observer_pattern
             What problems can the Observer design pattern solve?

              A one-to-many dependency between objects should be defined without making the objects tightly coupled.
              It should be ensured that when one object changes state an open-ended number of dependent objects are updated automatically.
              It should be possible that one object can notify an open-ended number of other objects.

            Defining a one-to-many dependency between objects by defining one object (subject)
            that updates the state of dependent objects directly is inflexible because it commits (tightly couples) the subject to particular dependent objects.

            Tightly coupled objects are hard to implement, change, test,
            and reuse because they refer to and know about (how to update) many different objects with different interfaces.
            */


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
