using System;
using System.Collections.Generic;
using System.Text;

namespace Flyweight.SimpleImplementation
{
    public class FlyWeight
    {
        public string CompanyName { get; set; }
        public string CompanyLocation { get; set; }
        public string CompanyWebSite { get; set; }
        //Bulky Data
        public byte[] CompanyLogo { get; set; }
    }
}
