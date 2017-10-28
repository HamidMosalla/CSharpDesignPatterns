using AbstractFactory.Cars.AbstractCars;

namespace AbstractFactory.Factory.AnstractFactory
{
    public abstract class CarFactory
    {
        public abstract SportsCar CreateSportsCar();
        public abstract FamilyCar CreateFamilyCar();
    }
}
