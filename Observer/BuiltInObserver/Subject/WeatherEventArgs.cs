using System;

namespace Observer.BuiltInObserver.Subject
{
    public class WeatherEventArgs : EventArgs
    {
        private double _temperature;

        public WeatherEventArgs(double temperature)
        {
            _temperature = temperature;
        }
        public double Temperature
        {
            get { return _temperature; }
        }
    }
}
