using System;
using System.Collections.Generic;
using System.Text;

namespace Builder.FluentBuilder
{
    class HouseBuilder : IHouseBuilder
    {
        private House _house;

        public HouseBuilder()
        {
            _house = new House();
        }

        public HouseBuilder Area(int area)
        {
            _house.Area = area;
            return this;
        }

        public HouseBuilder NumberOfRooms(int numberOfRooms)
        {
            _house.NumberOfRooms = numberOfRooms;
            return this;
        }

        public HouseBuilder HasGarage(bool hasGarage)
        {
            _house.HasGarage = hasGarage;
            return this;
        }

        public House Build()
        {
            House result = _house;
            _house = null; //prevent multiple invocations of Build()
            return result;
        }

    }
}
