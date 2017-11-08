using System;

namespace Observer.BuiltInObserver.Subject
{
    public class WeatherReport
    {
        public event EventHandler<WeatherEventArgs> WeatherChanged;

        public virtual void ReportWeather(WeatherEventArgs e)
        {
            // Make a temporary copy of the event to avoid possibility of
            // a race condition if the last subscriber unsubscribes
            // immediately after the null check and before the event is raised.
            EventHandler<WeatherEventArgs> handler = WeatherChanged;

            if (handler != null)
            {
                Console.WriteLine($"Central weather station reporting, new weather is {e.Temperature} C");
                handler(this, e);
            }
        }
    }
}
