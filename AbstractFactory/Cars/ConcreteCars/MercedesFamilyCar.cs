using System;
using AbstractFactory.Cars.AbstractCars;

namespace AbstractFactory.Cars.ConcreteCars
{
    class MercedesFamilyCar : FamilyCar
    {
        public override void Speed(SportsCar abstractSportsCar)
        {
            Console.WriteLine(GetType().Name + " is slower than "
                              + abstractSportsCar.GetType().Name);
        }
    }
}
