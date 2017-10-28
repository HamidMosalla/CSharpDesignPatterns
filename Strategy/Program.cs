using System;
using System.Collections.Generic;
using Strategy.Anbstraction;
using Strategy.Implementations;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            //More info on: http://www.dofactory.com/net/strategy-design-pattern

            var dataReaders = new List<IDataReader> { new XmlDataReader(), new JsonDataReader(), new SqlDataReader() };

            //Our client doesn't care how data readers reads data, it only cares that there is a method called *ReadData* which it can call.
            foreach (var dataReader in dataReaders)
            {
                dataReader.ReadData();
            }
        }
    }
}
