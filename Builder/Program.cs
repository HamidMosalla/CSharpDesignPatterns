using System;
using Builder.Builder.AbstractBuilder;
using Builder.Builder.ConcreteBuilder;
using Builder.Builder.Director;
using Builder.FluentBuilder;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            var house = new HouseBuilder()
                        .Area(500)
                        .NumberOfRooms(4)
                        .HasGarage(true)
                        .Build();

            // Lets create the Director first
            var manufacturer = new Manufacturer();

            // Now let us create an android phone
            IPhoneBuilder androidPhoneBuilder = new AndroidPhoneBuilder();
            var androidPhone = manufacturer.Construct(androidPhoneBuilder);

            // Now let us create a Windows Phone
            IPhoneBuilder windowsPhoneBuilder = new WindowsPhoneBuilder();
            var windowsPhone = manufacturer.Construct(windowsPhoneBuilder);
        }
    }
}
