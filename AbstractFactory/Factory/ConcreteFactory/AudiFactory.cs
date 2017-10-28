using AbstractFactory.Cars;
using AbstractFactory.Cars.AbstractCars;
using AbstractFactory.Cars.ConcreteCars;
using AbstractFactory.Factory.AnstractFactory;

namespace AbstractFactory.Factory.ConcreteFactory
{
    public class AudiFactory : CarFactory
    {
        public override SportsCar CreateSportsCar()
        {
            return new AudiSportsCar();
        }

        public override FamilyCar CreateFamilyCar()
        {
            return new AudiFamilyCar();
        }
    }
}
