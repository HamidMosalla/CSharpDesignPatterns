using System;
using Proxy.ActualObjects;
using Proxy.Proxy;

namespace Proxy
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
             * https://en.wikipedia.org/wiki/Proxy_pattern
             What problems can the Proxy design pattern solve?
             1-The access to an object should be controlled.
             2-Additional functionality should be provided when accessing an object.
             When accessing sensitive objects, for example, it should be possible to check that clients have the needed access rights.
            */

            ICar car = new ProxyCar(new Driver(16));
            car.DriveCar();

            car = new ProxyCar(new Driver(25));
            car.DriveCar();

            Console.ReadKey();
        }
    }
}
