using System;
using System.Collections.Generic;
using System.Text;

namespace Flyweight.SimpleImplementation
{
    public static class FlyWeightPointer
    {
        public static readonly FlyWeight Company = new FlyWeight
        {
            CompanyName = "Abc",
            CompanyLocation = "XYZ",
            CompanyWebSite = "www.abc.com"
            // Load CompanyLogo here
        };
    }
}
