using System;
using System.Collections.Generic;
using System.Text;

namespace Flyweight.SimpleImplementation
{
    public class ClientObject
    {
        //Here the FlyweightPointer creates a static member Company, which is used for every object of ClientObject.
        public string Name { get; set; }
        public string Company
        {
            get
            {
                return FlyWeightPointer.Company.CompanyName;
            }
        }
    }
}
