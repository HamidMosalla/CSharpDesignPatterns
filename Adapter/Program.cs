using System;
using Adapter.Adapter;
using Adapter.Client;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
             * The Adapter design pattern solves problems like:
                How can a class be reused that does not have an interface that a client requires?
                How can classes that have incompatible interfaces work together?
                How can an alternative interface be provided for a class?

                Often an (already existing) class can't be reused only 
                because its interface doesn't conform to the interface clients require.
             More info: https://csharpdesignpatterns.codeplex.com/wikipage?title=Adapter%20Pattern&referringTitle=Home
            */


            var tradingdataImporter = new TradingDataImporter();

            Connector databaseConnector = new DatabaseConnector();
            tradingdataImporter.ImportData(databaseConnector);

            Connector xmlfileConnector = new XmlFileConnector();
            tradingdataImporter.ImportData(xmlfileConnector);

            Connector httpstreamConnector = new HttpStreamConnector();
            tradingdataImporter.ImportData(httpstreamConnector);

            Console.ReadKey();
        }
    }
}