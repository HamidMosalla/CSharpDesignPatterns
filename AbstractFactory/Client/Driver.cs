using System;
using System.Collections.Generic;
using System.Text;
using AbstractFactory.Cars;
using AbstractFactory.Cars.AbstractCars;
using AbstractFactory.Factory;
using AbstractFactory.Factory.AnstractFactory;

namespace AbstractFactory.Client
{
    public class Driver
    {
        private SportsCar _sportsCar;
        private FamilyCar _familyCar;

        public Driver(CarFactory carFactory)
        {
            _sportsCar = carFactory.CreateSportsCar();
            _familyCar = carFactory.CreateFamilyCar();
        }

        public void CompareSpeed()
        {
            _familyCar.Speed(_sportsCar);
        }
    }
}
