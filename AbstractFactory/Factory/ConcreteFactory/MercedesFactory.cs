using AbstractFactory.Cars.AbstractCars;
using AbstractFactory.Cars.ConcreteCars;

namespace AbstractFactory.Factory.ConcreteFactory
{
    public class MercedesFactory : CarFactory
    {
        public override SportsCar CreateSportsCar()
        {
            return new MercedesSportsCar();
        }

        public override FamilyCar CreateFamilyCar()
        {
            return new MercedesFamilyCar();
        }
    }
}
