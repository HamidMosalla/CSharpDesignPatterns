using System;
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
        }
    }
}
