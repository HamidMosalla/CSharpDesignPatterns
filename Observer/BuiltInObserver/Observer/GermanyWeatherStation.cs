using System;
using Observer.BuiltInObserver.Subject;

namespace Observer.BuiltInObserver.Observer
{
    public class GermanyWeatherStation
    {
        public void GermanyWeatherChanged(object sender, WeatherEventArgs e)
        {
            Console.WriteLine($"Germany weather station receiving new transmission, temperature now is {e.Temperature + 4}");
        }
    }
}
