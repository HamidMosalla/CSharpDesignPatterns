using System;
using System.Collections.Generic;
using System.Text;
using AbstractFactory.Cars;
using AbstractFactory.Cars.AbstractCars;

namespace AbstractFactory.Factory
{
    public abstract class CarFactory
    {
        public abstract SportsCar CreateSportsCar();
        public abstract FamilyCar CreateFamilyCar();
    }
}
