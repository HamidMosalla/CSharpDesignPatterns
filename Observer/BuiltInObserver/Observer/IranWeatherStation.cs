using System;
using Observer.BuiltInObserver.Subject;

namespace Observer.BuiltInObserver.Observer
{
    public class IranWeatherStation
    {
        public void IranWeatherChanged(object sender, WeatherEventArgs e)
        {
            Console.WriteLine($"Iran weather station receiving new transmission, temperature now is {e.Temperature + 10}");
        }
    }
}
