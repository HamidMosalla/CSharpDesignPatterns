using System;
using System.Collections.Generic;
using System.Text;
using Strategy.Anbstraction;

namespace Strategy.Implementations
{
    class XmlDataReader: IDataReader
    {
        public void ReadData()
        {
            Console.WriteLine("Reading data from XML.");
        }
    }
}
