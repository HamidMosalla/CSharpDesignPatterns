using System;
using Observer.BuiltInObserver.Subject;

namespace Observer.BuiltInObserver.Observer
{
    public class UnitedStateWeatherStation
    {
        public void UnitedStateWeatherChanged(object sender, WeatherEventArgs e)
        {
            Console.WriteLine($"US weather station receiving new transmission, temperature now is {e.Temperature + 2}");
        }
    }
}
