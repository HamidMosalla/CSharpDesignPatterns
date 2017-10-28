using System;
using System.Collections.Generic;
using System.Text;

namespace Proxy.ActualObjects
{
    public class Car : ICar
    {
        public void DriveCar()
        {
            Console.WriteLine("Car has been driven!");
        }
    }
}
